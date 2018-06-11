using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models;

namespace WebAppDemoBiblioteca.viewmodels
{
    public class ListaLibrosViewModel
    {

        public IEnumerable<Libros> Libros { get; set; }
        public string CategoriaLibros { get; set; }
    }
}