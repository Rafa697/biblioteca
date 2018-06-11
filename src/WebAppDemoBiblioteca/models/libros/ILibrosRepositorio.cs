using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models
{
    public interface ILibrosRepositorio
    {
        IEnumerable<Libros> Libros { get; }
        IEnumerable<Libros> LibroDestacadosLectores { get; }

        Libros GetLibrosPorCodigo(int CodigoLibro);

    }
}
