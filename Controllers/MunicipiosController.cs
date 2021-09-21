using System;
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
    public class MunicipiosController : ControllerBase
    {
        private readonly ServidorDbContext _context;

        public MunicipiosController(ServidorDbContext context)
        {
            _context = context;
        }

        // GET: api/Municipios
        [HttpGet("{idDepartamento}")]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipios(int idDepartamento)
        {
            var municipios = from municipio in _context.Municipios where municipio.IdDepartamento == idDepartamento orderby municipio.NombreMunicipio.Substring(0,5) ascending select municipio;
            return await municipios.ToListAsync();
        }
    }
}
