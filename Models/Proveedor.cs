using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPRODUCTOS.Models
{
    public class Proveedor
    {
        public int Id { get; set; }


        [Display(Name = "Nombres")]
        public string nombres { get; set; }

        [Display(Name = "Teléfono")]
        public int telefono { get; set; }

        [Display(Name = "Domicilio")]
        public string domicilio { get; set; }

        [Display(Name = "Localidad")]
        public string localidad { get; set; }

        [Display(Name = "Provincia")]
        public string provincia { get; set; }

        public virtual List<ProveedoresProducto> proveedoresProductos { get; set; }

    }
}
