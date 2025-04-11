using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Model.Services
{
    public class CategoriaServices
    {
        private List<Categoria> tablaCategorias;

        public CategoriaServices()
        {
            tablaCategorias = new List<Categoria>();
        }

        public List<Categoria> GetAllCategorias()
        {
            return tablaCategorias;
        }

        public Categoria? GetCategoriaById(int id)
        {
            return tablaCategorias.Find(c => c.Id == id);
        }

        public bool CreateCategoria(Categoria categoria)
        {
            try
            {
                if (categoria == null)
                    return false;
                tablaCategorias.Add(categoria);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la categoria: {ex.Message}");
                return false;
            }
        }

        public bool UpdateCategoria(Categoria categoria)
        {
            try
            {
                var categoriaUpdate = GetCategoriaById(categoria.Id);
                if (categoriaUpdate != null)
                {
                    categoriaUpdate.Nombre = categoria.Nombre;
                    categoriaUpdate.IsActive = categoria.IsActive;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la categoria: {ex.Message}");
                return false;
            }
        }

        public bool DeleteCategoria(int id)
        {
            try
            {
                var categoriaToDelete = GetCategoriaById(id);
                if (categoriaToDelete != null)
                {
                    tablaCategorias.Remove(categoriaToDelete);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la categoria: {ex.Message}");
                return false;
            }
        }
    }
}
