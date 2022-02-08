using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPRODUCTOS.Models;

namespace WebAppPRODUCTOS.ViewsModels
{
    public class ProductosViewModel
    {//creamos un nuevo modelo para la vista que envie todo junto a la vista 
        public List<Producto> Productos  { get; set; }
        public SelectList Categorias { get; set; }
        public SelectList Marcas { get; set; }
        public string nombre { get; set; }
    }
}
