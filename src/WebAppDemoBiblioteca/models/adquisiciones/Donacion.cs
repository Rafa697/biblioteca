using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public class Donacion
    {
        public int CodigoDonacion { get; set; }

        public string ProveedorDonacion { get; set; }

        public List<Adquisiciones> Adquisiciones { get; set; }

    }
}
