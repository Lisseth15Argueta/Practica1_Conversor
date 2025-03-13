using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica1_Conversor.Models;

namespace Practica1_Conversor.Controllers
{
    public class ConversorController : Controller
    {
        public IActionResult Index()
        {
            return View(new Conversor());
        }

        [HttpPost]
        public IActionResult Index(Conversor model)
        {
            Console.WriteLine($"Valor: {model.Valor}, Origen: {model.UnidadOrigen}, Destino: {model.UnidadDestino}");
            
            if (ModelState.IsValid)
            {
                model.Convertir();
                Console.WriteLine($"Resultado: {model.Resultado}");
            }
            return View(model);
        }
    }
}