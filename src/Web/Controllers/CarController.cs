using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lamborghini()
        {
                
            return Json(new { success = true, brand = "Lamborghini", model = "Gallardo", type = "JSON"});
        }

        public IActionResult AlfaRomeo()
        {

            return Content("Alfa Romeo is another sport brand. Returned in text.");
        }

        public IActionResult Porsche()
        {

            return Content("<html><head><title>Porsche Carrera</title></head><body>Porsche, Returned in HTML</body></html>","text/html");
        }

        public IActionResult Ferrari()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
