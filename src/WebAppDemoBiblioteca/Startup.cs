using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebAppDemoBiblioteca.models.libros;
using WebAppDemoBiblioteca.models.editoriales;
using WebAppDemoBiblioteca.models.adquisiciones;
using WebAppDemoBiblioteca.models.usuarios;
using WebAppDemoBiblioteca.controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WebAppDemoBiblioteca.models;





namespace WebAppDemoBiblioteca
{
    public class Startup { 

        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnviroment)
         {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnviroment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
    }
    
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //regitrar AppDbContext
            services.AddDbContext<AppDbContext>(option =>
            option.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //registrar mis clases repositorio y mock
            //clase libros
            services.AddTransient<ICategoriasRepositorio, MockCategoriasRepositorio>();
            services.AddTransient<ILibrosRepositorio, MockLibrosRepositorio>();
            //clase editorial
            services.AddTransient<IDestacadosRepositorio, MockDestacadosRepositorio>();
            services.AddTransient<IEditorialesRepositorio, MockEditorialesRepositorio>();
            //clase adquisicion
            services.AddTransient<IAdquisionesRepositorio, MockAdquisicionesRepositorio>();
            services.AddTransient<IDonacionesRepositorio, MockDonacionesRepositorio>();
            //class usuarios
            //services.AddTransient<IUsuariosRepositorio, MockUsuariosRepositorio>();
            //actualizando por implementacion de EFCore
            //services.AddTransient<INivelesUsuariosRepositorio, NivelesUsuariosRepositorio>();

            //grega soporte MVC a mi proyecto
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();
            

        }
    }
}
