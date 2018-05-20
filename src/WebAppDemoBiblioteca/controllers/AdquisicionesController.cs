using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemoBiblioteca.models.adquisiciones;
using WebAppDemoBiblioteca.viewmodels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppDemoBiblioteca.controllers
{
    public class AdquisicionesController : Controller
    {

        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly IDonacionesRepositorio _donacionesRepositorio;
        private readonly IAdquisionesRepositorio _adquisicionesRepositorio;

        //constructor de esta clase controller
        public AdquisicionesController(IDonacionesRepositorio DonacionesRepositorio, IAdquisionesRepositorio AdquisicionesRepositorio)
        {
            _donacionesRepositorio = DonacionesRepositorio;
            _adquisicionesRepositorio = AdquisicionesRepositorio;
        }//fin del constructor

        //metodo para devolver la vista con datos inyectados

        public ViewResult ListaAdquisiciones()
        {
            //objetos para mostrar las categorias de los productos
            ListaAdquisicionesViewModel listaAdquisicionesViewModel = new ListaAdquisicionesViewModel();
            listaAdquisicionesViewModel.Adquisiciones = _adquisicionesRepositorio.Adquisiciones;

            //pasando intencionalmente un valor a la variedad de la clase
            listaAdquisicionesViewModel.TipoAdquisicion = "compra";



            return View(listaAdquisicionesViewModel);
        }//fin del metodo lista adquisiciones


    }
}
