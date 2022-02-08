using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPRODUCTOS.Models
{
    public class ProveedoresProducto
    {
        public int Id { get; set; }
        public int proveedorId { get; set; }
        public int categoriaId { get; set; }

        public Proveedor proveedor { get; set; }
        public Categoria categoria { get; set; }
    }
}
