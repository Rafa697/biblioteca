﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppDemoBiblioteca.models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }//fin del constructor

        public DbSet<usuarios.NivelesUsuario> NivUsuarios { get; set; }
        public DbSet<usuarios.usuarios> Usuarios { get; set; }
         public DbSet<CatLibros> CategoriaLibros { get; set; } 
        public  DbSet<Libros>  Libros { get; set; }

    }
}