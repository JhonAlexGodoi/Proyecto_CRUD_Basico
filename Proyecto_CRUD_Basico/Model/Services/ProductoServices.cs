using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Model.Services
{
    public class ProductoServices
    {
        private List<Producto> tablaProductos;

        public ProductoServices()
        {
            // Inicializar la lista de productos
            tablaProductos = new List<Producto>();
        }
        public List<Producto> GetAllProductos()
        {
            return tablaProductos;
        }
        public Producto? GetProductoById(int id)
        {
            return tablaProductos.Find(p => p.Id == id);
        }
        public List<Producto> GetProductosByCodigo(string codigo)
        {
            return tablaProductos.Where(p => p.CodigoBarra.Contains(codigo)).ToList();
        }
        public bool CreateProducto(Producto producto)
        {
            try
            {
                // Validaciones
                if (producto == null)
                    return false;
                if (string.IsNullOrWhiteSpace(producto.Nombre))
                    return false;
                if (producto.Precio <= 0 || producto.Stock < 0)
                    return false;

                // Agregar el producto a la lista
                tablaProductos.Add(producto);
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al crear el producto: {ex.Message}");
                return false;
            }
        }
        public bool UpdateProducto(Producto producto)
        {
            try
            {
                var productoUpdate = GetProductoById(producto.Id);
                if (productoUpdate != null)
                {
                    productoUpdate.Nombre = producto.Nombre;
                    productoUpdate.CodigoBarra = producto.CodigoBarra;
                    productoUpdate.Descripcion = producto.Descripcion;
                    productoUpdate.Precio = producto.Precio;
                    productoUpdate.Categoria = producto.Categoria;
                    productoUpdate.Stock = producto.Stock;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al actualizar el producto: {ex.Message}");
                return false;
            }
        }
        public bool DeleteProducto(int id)
        {
            try
            {
                var productoDelete = GetProductoById(id);
                if (productoDelete != null)
                {
                    tablaProductos.Remove(productoDelete);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al eliminar el producto: {ex.Message}");
                return false;
            }
        }
    }
}
