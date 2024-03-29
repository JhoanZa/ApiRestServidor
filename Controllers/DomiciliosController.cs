﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestProyecto.Data;
using ApiRestServidor.Modelos.Domicilio;

namespace ApiRestServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomiciliosController : ControllerBase
    {
        private readonly ServidorDbContext _context;

        public DomiciliosController(ServidorDbContext context)
        {
            _context = context;
        }

        // GET: api/Domicilios
        [HttpGet("{correoAsociado}")]
        public async Task<ActionResult<IEnumerable<Domicilio>>> GetDomicilios(String correoAsociado)
        {
            var domicilios = from domicilio in _context.Domicilios where domicilio.CorreoAsociado.Equals(correoAsociado) select domicilio;
            return await domicilios.ToListAsync();
        }

        // PUT: api/Domicilios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomicilio(int id, Domicilio domicilio)
        {
            if (id != domicilio.Id)
            {
                return BadRequest();
            }

            _context.Entry(domicilio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomicilioExists(id))
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

        // POST: api/Domicilios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Domicilio>> PostDomicilio(Domicilio domicilio)
        {
            _context.Domicilios.Add(domicilio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDomicilio", new { id = domicilio.Id }, domicilio);
        }

        // DELETE: api/Domicilios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomicilio(int id)
        {
            var domicilio = await _context.Domicilios.FindAsync(id);
            if (domicilio == null)
            {
                return NotFound();
            }

            _context.Domicilios.Remove(domicilio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomicilioExists(int id)
        {
            return _context.Domicilios.Any(e => e.Id == id);
        }
    }
}
