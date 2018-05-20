using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public interface IAdquisionesRepositorio
    {
        IEnumerable<Adquisiciones> Adquisiciones { get; }

        IEnumerable<Adquisiciones> AdquisicionesRecientes { get; }

        Adquisiciones GetAdquisicionesPorCodigo(int CodigoAdquisicion);

    }
}

