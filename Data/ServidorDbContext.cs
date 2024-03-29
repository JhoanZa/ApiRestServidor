﻿using ApiRestProyecto.Modelos;
using ApiRestServidor.Modelos.Domicilio;
using ApiRestServidor.Modelos.Producto;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiRestProyecto.Data
{
    public class ServidorDbContext : IdentityDbContext
    {
        public ServidorDbContext(DbContextOptions<ServidorDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Domicilio> Domicilios { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }

    }
}
