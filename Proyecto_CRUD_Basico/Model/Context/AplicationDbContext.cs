using Microsoft.EntityFrameworkCore;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Model.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(
            DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<User> User { get; set; }


    }
}
