using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models.editoriales;

namespace WebAppDemoBiblioteca.viewmodels
{
    public class ListaEditorialesViewModel
    {
        public IEnumerable<Editoriales> Editoriales { get; set; }

        public string EditorialesDestacados { get; set; }
    }
}
