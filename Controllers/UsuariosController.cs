using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestProyecto.Data;
using ApiRestProyecto.Modelos;

namespace ApiRestProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ServidorDbContext _context;

        public UsuariosController(ServidorDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios/5
        [HttpGet("{correo}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{correo}")]
        public async Task<IActionResult> PutUsuario(string id, Usuario usuario)
        {
            if (id != usuario.Correo)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioExists(usuario.Correo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuario", new { id = usuario.Correo }, usuario);
        }

        private bool UsuarioExists(string id)
        {
            return _context.Usuarios.Any(e => e.Correo == id);
        }
    }
}
