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
    public class DepartamentosController : ControllerBase
    {
        private readonly ServidorDbContext _context;

        public DepartamentosController(ServidorDbContext context)
        {
            _context = context;
        }

        // GET: api/Departamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamentos()
        {
            var departamentos = from departamento in _context.Departamentos orderby departamento.Nombre.Substring(0, 3) ascending select departamento;
            return await departamentos.ToListAsync();
        }
    }
}
