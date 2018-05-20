using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.libros
{
    public interface ILibrosRepositorio
    {
        IEnumerable<Libros> Libros { get; }

        IEnumerable<Libros> LibroOferta { get; }

        Libros GetLibrosPorCodigo(int CodigoLibro);
        
    }
}
