using _24CV_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24CV_WEB.Controllers
{
    public class EjemplosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Tapia";
            persona.Apellidos = "Rendón";
            persona.FechaNacimiento = new DateTime(2003, 09, 15);
            return View(persona);
        }
    }
}
