using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public interface IEditorialesRepositorio
    {
        IEnumerable<Editoriales> Editoriales { get; }

        IEnumerable<Editoriales> EditorialesOferta { get; }

        Editoriales GetEditorialesPorCodigo(int CodigoEditorial);

    }
}

