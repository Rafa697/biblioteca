using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebAppDemoBiblioteca.models.usuarios
{
    public class NivelesUsuario
    {
        [Key]
        public int CodigoNivel  { get; set; }

        public string NombreNivel { get; set; }

        public string DescripcionNivel { get; set; }
        public List<usuarios> Usuarios { get; set; }
    }
}
