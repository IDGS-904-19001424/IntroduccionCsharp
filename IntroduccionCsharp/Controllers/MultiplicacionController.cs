using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        [HttpGet]
        public ActionResult MultSuma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MultSuma(Multiplicacion mult)
        {

            mult.SumaFor();
            return View(mult);
        }

    }
}