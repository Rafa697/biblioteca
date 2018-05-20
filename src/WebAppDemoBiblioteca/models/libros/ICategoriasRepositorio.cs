using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.libros
{
    public interface ICategoriasRepositorio
    {
        IEnumerable<CategoriaLibros> CategoriaLibros { get; }

        IEnumerable<CategoriaLibros> CategoriasOfertas { get; }

       

    }
}

