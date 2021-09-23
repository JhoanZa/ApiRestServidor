using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestProyecto.Data;
using ApiRestServidor.Modelos.Producto;

namespace ApiRestServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ServidorDbContext _context;

        public CategoriasController(ServidorDbContext context)
        {
            _context = context;
        }

        // GET: api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            var categorias = from categoria in _context.Categorias orderby categoria.Nombre.Substring(0, 3) ascending select categoria;
            return await categorias.ToListAsync();
        }
    }
}
