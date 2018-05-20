using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models.libros;

namespace WebAppDemoBiblioteca.viewmodels
{
    public class ListaLibrosViewModel
    {

        public IEnumerable<Libros> Libros { get; set; }

        public string CategoriasLibros { get; set; }
    }
}