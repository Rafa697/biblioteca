using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.usuarios
{
    public class MockNivelesUsuariosRepositorio : INivelesUsuariosRepositorio
    {
        public IEnumerable<NivelesUsuario> NivUsuarios
        {
            get
            {
                return new List<NivelesUsuario>
                {
                    new NivelesUsuario {CodigoNivel=1, NombreNivel="Administrador", DescripcionNivel="Este nivel posee todos los privilegios del sistema" },
                    new NivelesUsuario {CodigoNivel=2, NombreNivel="Bibliotecario", DescripcionNivel="Este nivel posee privilegios estandar en el sistema" },
                    new NivelesUsuario {CodigoNivel=3, NombreNivel="Supervisor", DescripcionNivel="Este nivel posee privilegios de lectura y edicion en el sitema"},
                    new NivelesUsuario {CodigoNivel=4, NombreNivel="Cliente" , DescripcionNivel="Este nivel posee privilegios de solo lectura en el sistema"}
                };

            }//fin del get
        }//fin del ienumerable

    }//fin del public class
}
