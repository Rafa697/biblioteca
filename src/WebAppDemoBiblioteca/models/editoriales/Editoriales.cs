using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public class Editoriales
    {
        public int CodigoEditorial { get; set; }

        public string NombreEditorial { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public string Email { get; set; }

        public virtual Destacados Destacados { get; set; }
    }
}
