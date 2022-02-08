using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPRODUCTOS.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Display(Name = "Nombres")]
        [Required]
        public string nombres { get; set; }

        [Display(Name = "Precio")]
        //[DataType(DataType.Currency)]
        // [Column(TypeName = "money")]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal precio { get; set; }

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }

        [Display(Name = "Imagen")]
        
        public string imagen { get; set; }

        [Display(Name = "Favorito")]
        public bool favorito { get; set; }

        public int categoriaId { get; set; }
        [Display(Name = "Categoría")]
        public Categoria categoria { get; set; }

        public int marcaId { get; set; }
        [Display(Name = "Marca")]
        public Marca marca { get; set; }

        public virtual List<ProveedoresProducto> proveedoresProductos{ get; set; }
    }
}
