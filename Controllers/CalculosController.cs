using Back_endEjemplo1.Models;
using Back_endEjemplo1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string n1, string n2) 
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;

            return View();
        }

        public ActionResult Operacion()
        {
            OperasBas op = new OperasBas();
            op.Res = 0;
            return View(op);
        }
        [HttpPost]
        public ActionResult Operacion(OperasBas op)
        {
            op.Suma();
            return View(op);
        }

        public ActionResult Resta(OperasBas op)
        {
            op.Resta();
            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult MuestraPelicula2()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

        //TIPOS DE DEVOLUCIÓN
        // -ActionResult
        // -ContentResult
        // -JsonResult
        // -ViewResult
        // -RedirectResult
        public ContentResult Temporal() //Retornar contenido de datos
        {
            return Content("<h1> Hola mundo </h1>");
            //JsonResult
            //var alumno = new Alumno() { Nombre=Juan, Edad=20 }
            //return Json(alumno1, JsonRequestBehavior.AllowGet);
            }
        }

        //Regresar vistas ViewResult 
        //return View();
        //RedirectResult
        //return Redirect("https://Google.com")
        //Otro redirect
        //return Redirect

    }
}