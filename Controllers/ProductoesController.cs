using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppPRODUCTOS.Models;

namespace WebAppPRODUCTOS.Controllers
{
    public class ProductoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment env;//declaramos una tributo con datos del servidor

        public ProductoesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.productos.Include(p => p.categoria).Include(p => p.marca);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.productos
                .Include(p => p.categoria)
                .Include(p => p.marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            ViewData["categoriaId"] = new SelectList(_context.categorias, "Id", "descripcion");
            ViewData["marcaId"] = new SelectList(_context.marcas, "Id", "descripcion");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nombres,precio,descripcion,imagen,favorito,categoriaId,marcaId")] Producto producto)
        {
            if (ModelState.IsValid)//verifica las etiquetas de nuestro modelo: si es requerido, si cumple con el rango, etc
            {
                var archivos = HttpContext.Request.Form.Files;//httpcontext -> es la clase que permite capturar los achivos que se envian a traves del form web
                if (archivos != null && archivos.Count > 0) //como es archivoos=coleccion accedemos a los elementos
                {
                    var archivoFoto = archivos[0];//accedemos al archivo unico 

                    if (archivoFoto.Length > 0) //si hay contenido
                    {
                        var pathDestino = Path.Combine(env.WebRootPath, "images");//concatena la ruta (string) es necesario definir el env (al principio esta)
                        //genera un nombre aleatorio del archivo destino fotografia
                        var archivoDestino = Guid.NewGuid().ToString()//guid->genera un hash aleatorio
                            .Replace("-", "") + Path.GetExtension(archivoFoto.FileName); //concatenamos la extención del archivo
                        var rutaDestino = Path.Combine(pathDestino, archivoDestino);//concatenamos el pathdestino y el archivodestino

                        using (var filestream = new FileStream(rutaDestino, FileMode.Create))//using -> cuando termina libera los recursos usados
                        {
                            archivoFoto.CopyTo(filestream);
                            producto.imagen = archivoDestino;
                        };

                    }

                }

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoriaId"] = new SelectList(_context.categorias, "Id", "Id", producto.categoriaId);
            ViewData["marcaId"] = new SelectList(_context.marcas, "Id", "Id", producto.marcaId);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["categoriaId"] = new SelectList(_context.categorias, "Id", "descripcion", producto.categoriaId);
            ViewData["marcaId"] = new SelectList(_context.marcas, "Id", "descripcion", producto.marcaId);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nombres,precio,descripcion,imagen,favorito,categoriaId,marcaId")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var archivoFoto = archivos[0];
                    if (archivoFoto.Length > 0)
                    {
                        var pathDestino = Path.Combine(env.WebRootPath, "images");
                        var archivoDestino = Guid.NewGuid().ToString()//guid->genera un hash aleatorio
                            .Replace("-", "") + Path.GetExtension(archivoFoto.FileName); //concatenamos la extención del archivo
                        var rutaDestino = Path.Combine(pathDestino, archivoDestino);//concatenamos el pathdestino y el archivodestino

                        if (!string.IsNullOrEmpty(producto.imagen)) //para revisar si habia foto precargada y no se rompa
                        {
                            //si existe una foto anterior se elimine
                            string fotoAnterior = Path.Combine(pathDestino, producto.imagen);
                            if (System.IO.File.Exists(fotoAnterior))
                            {
                                System.IO.File.Delete(fotoAnterior);
                            }
                        }

                        using (var filestream = new FileStream(rutaDestino, FileMode.Create))//using -> cuando termina libera los recursos usados
                        {
                            archivoFoto.CopyTo(filestream);
                            producto.imagen = archivoDestino;
                        };

                    }
                }
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoriaId"] = new SelectList(_context.categorias, "Id", "Id", producto.categoriaId);
            ViewData["marcaId"] = new SelectList(_context.marcas, "Id", "Id", producto.marcaId);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.productos
                .Include(p => p.categoria)
                .Include(p => p.marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.productos.FindAsync(id);
            _context.productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.productos.Any(e => e.Id == id);
        }
    }
}
