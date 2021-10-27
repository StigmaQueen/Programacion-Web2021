using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Villancicos.Models;
using System.Threading.Tasks;

namespace Villancicos.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var v = context.Villancicos.OrderBy(x => x.Nombre);
            return View(v);
        }
        [Route("Villancico/{nombre}")]
        public IActionResult Villancico(string nombre)
        {
            nombre = nombre.Replace("-", " ");
            villancicosContext context = new villancicosContext();
            var cancion = context.Villancicos.FirstOrDefault(x => x.Nombre == nombre);
            if (cancion == null)
            {
                return RedirectToAction("Index");
            }
            return View(cancion);
        }
        [Route("Ingles")]
        public IActionResult VIngles()
        {
            villancicosContext context = new villancicosContext();
            var vI = context.Villancicos.OrderBy(x => x.Nombre).Where(x => x.Idioma == "Inglés");
            return View(vI);
        }
        [Route("Español")]
        public IActionResult VEsp()
        {
            villancicosContext context = new villancicosContext();
            var vE = context.Villancicos.OrderBy(x => x.Nombre).Where(x => x.Idioma == "Español");
            return View(vE);
        }
    }
}

