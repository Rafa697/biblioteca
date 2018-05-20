using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public class Destacados
    {
        public int CodigoDestacados { get; set; }

        public string NombreDestacados { get; set; }

        public List<Editoriales> Editoriales { get; set; }
    }
}
