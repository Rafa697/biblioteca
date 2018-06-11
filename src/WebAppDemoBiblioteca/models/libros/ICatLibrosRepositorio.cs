using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models
{
    public interface ICatLibrosRepositorio
    {
        IEnumerable<CatLibros> CategoriaLibros { get; }

    }
}
