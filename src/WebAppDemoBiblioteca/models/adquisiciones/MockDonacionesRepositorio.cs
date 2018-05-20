using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public class MockDonacionesRepositorio : IDonacionesRepositorio
    {
        public IEnumerable<Donacion> Donacion
        {
            get
            {
                return new List<Donacion>
                {
                    new Donacion {CodigoDonacion = 1, ProveedorDonacion = "Realista"},
                    new Donacion {CodigoDonacion = 2, ProveedorDonacion = "Fantasia" },
                    new Donacion {CodigoDonacion= 3, ProveedorDonacion= "Basado en hechos reales" }
                };
            }//FIN DEL GET
        }//fin del IEnumerable

        public IEnumerable<Donacion> DonacionesRecientes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Donacion> Donaciones
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Donacion> DonacionesReciente
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }//fin de public class
}

