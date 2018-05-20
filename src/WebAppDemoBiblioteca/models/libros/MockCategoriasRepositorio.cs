using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemoBiblioteca.models;

namespace WebAppDemoBiblioteca.models.libros
{
    public class MockCategoriasRepositorio: ICategoriasRepositorio
    {
        public IEnumerable<CategoriaLibros> CategoriaLibros
        {
            get
            {
                return new List<CategoriaLibros>
                {
                    new CategoriaLibros {CodigoCategoria = 1, NombreCategoria = "Realista"},
                    new CategoriaLibros {CodigoCategoria = 2, NombreCategoria = "Fantasia" },
                    new CategoriaLibros {CodigoCategoria= 3, NombreCategoria= "Basado en hechos reales" }
                };
            }//FIN DEL GET
        }//fin del IEnumerable

        public IEnumerable<CategoriaLibros> CategoriasOfertas
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }//fin de public class
}
