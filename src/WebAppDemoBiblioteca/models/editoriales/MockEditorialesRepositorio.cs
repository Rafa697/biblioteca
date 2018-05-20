using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.editoriales
{
    public class MockEditorialesRepositorio : IEditorialesRepositorio
    {
        private readonly IDestacadosRepositorio _DestacadosRepositorio = new MockDestacadosRepositorio();

        public IEnumerable<Editoriales> Editoriales
        {
            get
            {
                return new List<Editoriales>
                {
                    new Editoriales {CodigoEditorial = 1, NombreEditorial = "Cientos", Direccion = "col. cucomacayan", Telefono = 22154080, Email = "cientos.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 2, NombreEditorial = "futuro", Direccion = "colonia medica", Telefono = 25789015, Email  = "futuro.11@gmail.com",  },
                    new Editoriales {CodigoEditorial = 3, NombreEditorial = "la capiña", Direccion = "redondel integracion", Telefono = 77984510, Email  = "lacapiña.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 4, NombreEditorial = "diarios perdidos", Direccion = "plaza san luis", Telefono = 25411441, Email  = "diariosperdidos.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 5, NombreEditorial = "roble", Direccion = "antiguo cuscatlan", Telefono = 22134158, Email  = "roble.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 6, NombreEditorial = "iberoamerica", Direccion = "colonia atlacalt", Telefono = 25789541, Email  = "roamericana.11@gmail.comibe" },
                    new Editoriales {CodigoEditorial = 7, NombreEditorial = "americanos", Direccion = "avenida fidel castro", Telefono = 22145786, Email  = "americanos.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 8, NombreEditorial = "el buen gusto", Direccion = "zaragoza calle la pedrada", Telefono = 25272921, Email  = "elbuengusto.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 9, NombreEditorial = "lector fiel", Direccion = "sensuntepeque calle los olvidados", Telefono = 22777777, Email  = "lectorfiel.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 10, NombreEditorial = "perdidos", Direccion = "col. cucomacayan", Telefono = 25551461, Email  = "perdidos.11@gmail.com" },
                    new Editoriales {CodigoEditorial = 11, NombreEditorial = "europeos", Direccion = "nueva san salvador ", Telefono = 25347965, Email  = "europeos.11@gmail.com" }

                };
            }//fin del get
        }//fin de IEnumerable Libros

        public IEnumerable<Editoriales> EditorialesOferta { get; }

        public IEnumerable<Editoriales> EditorialOferta
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Editoriales GetEditorialesPorCodigo(int CodigoEditorial)
        {
            throw new System.NotImplementedException();
        }
    }//fin del public class
}
