using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Model.Entities;
using Proyecto_CRUD_Basico.Model.Services;

namespace Proyecto_CRUD_Basico.Controllers
{
    public class ProductoControllers
    {
        private readonly ProductoServices _productoServices;

        public ProductoControllers()
        {
            _productoServices = new ProductoServices();
        }

        public List<Producto> GetAllProductos()
        {
            return _productoServices.GetAllProductos();
        }

        public bool CreateProducto(Producto producto)
        {
            if (producto == null)
                return false;
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                return false;
            if (producto.Precio <= 0 || producto.Stock < 0)
                return false;
            return _productoServices.CreateProducto(producto);
        }

        public Producto GetProductoById(int id)
        {
            if (id <= 0)
                return null;
            return _productoServices.GetProductoById(id);
        }

        public List<Producto>GetProductosByCodigo(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
                return null;
            return _productoServices.GetProductosByCodigo(codigo);
        }

        public bool UpdateProducto(Producto producto)
        {
            if (producto == null)
                return false;
            return _productoServices.UpdateProducto(producto);
        }

        public bool DeleteProducto(int id)
        {
            if (id <= 0)
                return false;
            return _productoServices.DeleteProducto(id);
        }
    }

}
