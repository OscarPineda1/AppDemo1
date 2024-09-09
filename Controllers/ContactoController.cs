using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppDemo1.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar(Contacto contacto)
        {
            ViewData["MsgRespuesta"] =  "Gracias por contactarnos, nos pondremos en contacto pronto " + contacto.Nombre;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

    public class Contacto
    {
        public String? Nombre{get; set;}
        public String? Email{get; set;}
        public String? Mensaje{get; set;}

        public int Edad{get; set;}
    }
}