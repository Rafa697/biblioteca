﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppDemoBiblioteca.models.usuarios;

namespace WebAppDemoBiblioteca.models.usuarios
{
    public class usuarios
    {
        [Key]
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string UsernameUsuario { get; set; }
     
        public string DireccionUsuario { get; set; }
        public string EstadoUsuario { get; set; }

        public int Edad { get; set; }

        public int CodigoNivel { get; set; }
        

        public virtual NivelesUsuario NivUsuarios { get; set; }

    }
}
