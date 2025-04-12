using Microsoft.EntityFrameworkCore;
using Proyecto_CRUD_Basico.Model.Context;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Model.Services
{
    public class CategoriaServices
    {
        private readonly AplicationDbContext _context;

        public CategoriaServices()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(Properties.Settings.Default.ConnectionString);

            _context = new AplicationDbContext(optionsBuilder.Options);
        }

        public List<Categoria> GetAllCategorias()
        {
            return _context.Categoria.ToList();
        }

        public Categoria? GetCategoriaById(int id)
        {
            return _context.Categoria.Find(id);
        }

        public bool CreateCategoria(Categoria categoria)
        {
            try
            {
                if (categoria == null)
                    return false;
                _context.Categoria.Add(categoria);
                _context.SaveChanges();
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
                    _context.SaveChanges();
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
                    _context.Categoria.Remove(categoriaToDelete);
                    _context.SaveChanges();
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
