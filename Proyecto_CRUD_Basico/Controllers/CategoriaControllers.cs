using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CRUD_Basico.Model.Entities;
using Proyecto_CRUD_Basico.Model.Services;

namespace Proyecto_CRUD_Basico.Controllers
{
    public class CategoriaControllers
    {
        private readonly CategoriaServices _categoriaServices;
        public CategoriaControllers()
        {
            _categoriaServices = new CategoriaServices();
        }
        public List<Categoria> GetAllCategorias()
        {
            return _categoriaServices.GetAllCategorias();
        }
        public bool CreateCategoria(Categoria categoria)
        {
            if (categoria == null)
                return false;
            return _categoriaServices.CreateCategoria(categoria);
        }

        public Categoria? GetCategoriaById(int id)
        {
            if (id <= 0)
                return null;
            return _categoriaServices.GetCategoriaById(id);
        }

        public bool UpdateCategoria(Categoria categoria)
        {
            if (categoria == null)
                return false;
            return _categoriaServices.UpdateCategoria(categoria);
        }

        public bool DeleteCategoria(int id)
        {
            if (id <= 0)
                return false;
            return _categoriaServices.DeleteCategoria(id);
        }
    }
}
