using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemoBiblioteca.models.libros;
using WebAppDemoBiblioteca.viewmodels;




namespace WebAppDemoBiblioteca.controllers
{
    public class LibrosController : Controller
    {
        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly ICategoriasRepositorio _categoriasRepositorio;
        private readonly ILibrosRepositorio _librosRepositorio;

        //constructor de esta clase controller
        public LibrosController(ICategoriasRepositorio CategoriasRepositorio, ILibrosRepositorio librosRepositorio)
        {
            _categoriasRepositorio = CategoriasRepositorio;
            _librosRepositorio = librosRepositorio;
        }//fin del constructor

        //metodo para devolver la vista con datos inyectados

        public ViewResult ListaLibros()
        {
            //objetos para mostrar las categorias de los productos
            ListaLibrosViewModel listalibrosViewModel = new ListaLibrosViewModel();
            listalibrosViewModel.Libros = _librosRepositorio.Libros.Where(c=> c.EstadoLibro==0);

            //pasando intencionalmente un valor a la variedad de la clase
            listalibrosViewModel.CategoriasLibros = "Libros Realista";

            

            return  View(listalibrosViewModel);
        }//fin del metodo lista libros

        
        }
    }

