using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using PortafolioJMEC.Models;
namespace PortafolioJMEC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            string filePath = Path.Combine(_env.WebRootPath, "data", "proyectos.json");
            List<Proyecto> listaProyectos = new List<Proyecto>();

            if (System.IO.File.Exists(filePath))
            {
                string jsonContent = System.IO.File.ReadAllText(filePath);
                listaProyectos = JsonSerializer.Deserialize<List<Proyecto>>(jsonContent) ?? new List<Proyecto>();
            }

            return View(listaProyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }
    }
}
