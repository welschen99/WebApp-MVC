using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPRODUCTOS.Models
{
    public class Marca
    {
        public int Id { get; set; }

        [Display(Name = "Marcas")]
        public string descripcion { get; set; }
        public List<Producto> producto { get; set; }
    }
}
