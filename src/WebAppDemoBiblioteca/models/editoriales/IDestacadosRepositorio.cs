using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public interface IDestacadosRepositorio
    {
        IEnumerable<Destacados> Destacados { get; }

        IEnumerable<Destacados> DestacadosOfertas { get; }


    }
}
