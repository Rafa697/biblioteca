using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models.usuarios;

namespace WebAppDemoBiblioteca.viewmodels
{
    public class ListaUsuariosViewModel
    {
        public IEnumerable<usuarios> Usuarios { get; set; }
        public string Titulo { get; set; }
    }
}
