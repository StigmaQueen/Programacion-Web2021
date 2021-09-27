using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activivdad2.Models;

namespace Activivdad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Promedio p)
        {
            return View(p);
        }
    }
}
