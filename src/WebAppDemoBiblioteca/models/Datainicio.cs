using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemoBiblioteca.models
{
    public static class DataInicio
    {
       public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();
            
            if(!contexto.NivUsuarios.Any())
            {
               
                contexto.NivUsuarios.AddRange(NivelesUsuariosIniciales.Select(c => c.Value));
            }
            if (!contexto.Usuarios.Any())
            {
                contexto.AddRange
                    (
            new usuarios.usuarios { NombreUsuario = "Rafael Chavez", UsernameUsuario = "adminrafa", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 35, CodigoNivel = 1, NivUsuarios = NivelesUsuariosIniciales["Administrador"] },
            new usuarios.usuarios { NombreUsuario = "Neidy Yohami", UsernameUsuario = "biblioneidy", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 40, CodigoNivel = 2, NivUsuarios = NivelesUsuariosIniciales["Bibliotecario"] },
            new usuarios.usuarios { NombreUsuario = "Guillermo Galan", UsernameUsuario = "adminguillermo", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 40, CodigoNivel = 1, NivUsuarios = NivelesUsuariosIniciales["Administrador"] },
            new usuarios.usuarios { NombreUsuario = "Raul Alexis", UsernameUsuario = "superraul", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 30, CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["Cliente"] },
            new usuarios.usuarios { NombreUsuario = "Franklin Bermudez", UsernameUsuario = "franklin123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 25, CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["Cliente"] },
            new usuarios.usuarios { NombreUsuario = "Carlos Solis", UsernameUsuario = "carlos123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 27, CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["Cliente"] },
            new usuarios.usuarios { NombreUsuario = "Alexander Zometa", UsernameUsuario = "alexander123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 24, CodigoNivel = 4, NivUsuarios = NivelesUsuariosIniciales["Universitario"] },
            new usuarios.usuarios { NombreUsuario = "Uriel Cortez", UsernameUsuario = "uri123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 23, CodigoNivel = 4, NivUsuarios = NivelesUsuariosIniciales["Universitario"] },
            new usuarios.usuarios { NombreUsuario = "Alexis Diaz", UsernameUsuario = "alexis123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 18, CodigoNivel = 5, NivUsuarios = NivelesUsuariosIniciales["Bachiller"] },
            new usuarios.usuarios { NombreUsuario = "Adolfo Olmedo", UsernameUsuario = "adolf123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 18, CodigoNivel = 5, NivUsuarios = NivelesUsuariosIniciales["Bachiller"] },
            new usuarios.usuarios { NombreUsuario = "Baudilio Berrios", UsernameUsuario = "baudi123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 17, CodigoNivel = 5, NivUsuarios = NivelesUsuariosIniciales["Bachiller"] },
            new usuarios.usuarios { NombreUsuario = "Eduardo  Valdizon", UsernameUsuario = "eduardo123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 15, CodigoNivel = 6, NivUsuarios = NivelesUsuariosIniciales["Basica"] },
            new usuarios.usuarios { NombreUsuario = "Alberto Aquino", UsernameUsuario = "alber123", DireccionUsuario = "SS", EstadoUsuario = "Activo", Edad = 15, CodigoNivel = 6, NivUsuarios = NivelesUsuariosIniciales["Basica"] }

                    );
            }
            contexto.SaveChanges();
        }
        public static Dictionary<string, usuarios.NivelesUsuario> nivusuariosiniciales;
        public static Dictionary<string, usuarios.NivelesUsuario> NivelesUsuariosIniciales
        {
            get
            {
                if(nivusuariosiniciales == null)
                {
                    var listadoNiveles = new usuarios.NivelesUsuario[]
                    {
                        new usuarios.NivelesUsuario {NombreNivel="Administrador" },
                        new usuarios.NivelesUsuario {NombreNivel="Bibliotecario" },
                        new usuarios.NivelesUsuario {NombreNivel="Cliente" },
                        new usuarios.NivelesUsuario {NombreNivel="Universitario" },
                        new usuarios.NivelesUsuario {NombreNivel="Bachiller" },
                        new usuarios.NivelesUsuario {NombreNivel="Basica" }
                    };
                    nivusuariosiniciales = new Dictionary<string, usuarios.NivelesUsuario>();
                    
                    foreach(usuarios.NivelesUsuario nivusuini in listadoNiveles)
                    {
                        nivusuariosiniciales.Add(nivusuini.NombreNivel, nivusuini);
                    }//fin del foreach
                }
                return nivusuariosiniciales;
            }//fin del metodo get
        }//fin del diccionario de categorias
    }
}
