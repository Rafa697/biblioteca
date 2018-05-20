using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.libros
{
    public class CategoriaLibros
    {
        public int CodigoCategoria { get; set; }

        public string NombreCategoria { get; set; }

        public List<Libros> Libros { get; set; }

    }
}
