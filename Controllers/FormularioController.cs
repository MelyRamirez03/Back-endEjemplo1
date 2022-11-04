using Back_endEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            var model = new Pelicula();
            return View(model);
        }

        public ActionResult Index2()
        {
            var model = new Pelicula();
            return View(model);
        }
    }
}