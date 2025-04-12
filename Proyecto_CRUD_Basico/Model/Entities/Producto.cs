using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_CRUD_Basico.Model.Entities
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(10)]
        public string CodigoBarra { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }

        [Required]
        public int Precio { get; set; }

        //CREAMOS CLAVES FORANEAS
        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        //**********************

        [Required]
        public int Stock { get; set; }

        public string Imagen {  get; set; }

    }
}
