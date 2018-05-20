using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public interface IDonacionesRepositorio
    {
        IEnumerable<Donacion> Donacion { get; }

        IEnumerable<Donacion> DonacionesRecientes { get; }



    }
}