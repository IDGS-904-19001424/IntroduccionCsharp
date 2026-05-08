using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroduccionCsharp.Models;
using IntroduccionCsharp.Services;

namespace IntroduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Suma(string x , string y, string r1)
        {

                int res = Convert.ToInt32(x) + Convert.ToInt32(y);
                ViewBag.res = Convert.ToString(res);

            return View();
    }
        public ActionResult Calculo(OperaBas op)
        {
            op.Suma();

            return View(op);
        }


        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService();
            var model = PeliculasService.ObtenerPelicula();

            return View(model); 
        }
}
}