using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models.adquisiciones;

namespace WebAppDemoBiblioteca.viewmodels
{
    public class ListaAdquisicionesViewModel
    {
        public IEnumerable<Adquisiciones> Adquisiciones { get; set; }

        public string TipoAdquisicion { get; set; }
    }
}
