using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public class MockDestacadosRepositorio : IDestacadosRepositorio
    {

        public IEnumerable<Destacados> Destacados
        {
            get
            {
                return new List<Destacados>
                {
                    new Destacados {CodigoDestacados = 1, NombreDestacados = "Realista"},
                    new Destacados {CodigoDestacados = 2, NombreDestacados = "Fantasia" },
                    new Destacados {CodigoDestacados= 3, NombreDestacados = "Basado en hechos reales" }
                };
            }//FIN DEL GET
        }//fin del IEnumerable

        public IEnumerable<Destacados> DestacadosOfertas
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Destacados> DestacadoOfertas
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }//fin de public class
}
