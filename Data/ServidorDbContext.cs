using ApiRestProyecto.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestProyecto.Data
{
    public class ServidorDbContext : IdentityDbContext
    {
        public ServidorDbContext(DbContextOptions<ServidorDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }

    }
}
