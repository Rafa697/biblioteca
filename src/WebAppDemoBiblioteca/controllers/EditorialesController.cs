using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemoBiblioteca.models.editoriales;
using WebAppDemoBiblioteca.viewmodels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppDemoBiblioteca.controllers
{
    public class EditorialesController : Controller
    {

        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly IEditorialesRepositorio _editorialesRepositorio;
        private readonly IDestacadosRepositorio _destacadosRepositorio;

        //constructor de esta clase controller
        public EditorialesController(IDestacadosRepositorio DestacadosRepositorio, IEditorialesRepositorio EditorialesRepositorio)
        {
            _destacadosRepositorio = DestacadosRepositorio;
            _editorialesRepositorio = EditorialesRepositorio;
        }//fin del constructor

        //metodo para devolver la vista con datos inyectados

        public ViewResult ListaEditoriales()
        {
            //objetos para mostrar las categorias de los productos
            ListaEditorialesViewModel listaEditorialesViewModel = new ListaEditorialesViewModel();
            listaEditorialesViewModel.Editoriales = _editorialesRepositorio.Editoriales;

            //pasando intencionalmente un valor a la variedad de la clase
            listaEditorialesViewModel.EditorialesDestacados = "Editoriales";



            return View(listaEditorialesViewModel);
        }//fin del metodo lista libros


    }
}
