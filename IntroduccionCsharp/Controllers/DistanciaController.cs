using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        [HttpGet]
        public ActionResult CalculoDist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculoDist(Distancia dis)
        {
            dis.Operacion();
            return View(dis);
        }
    }
}