using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.libros
{
    public class Libros
    {
      
        public int CodigoLibro { get; set; }

        public string NombreLibro { get; set; }

        public string DescripLibro { get; set; }

        public int CodigoCategoria { get; set; }

        public string AutorLibro { get; set; }

        public string EditorialLibro { get; set; }

        public int EstadoLibro { get; set; }

        public virtual CategoriaLibros CategoriasLibros { get; set; }

    }
}
