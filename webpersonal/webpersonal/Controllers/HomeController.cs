using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webpersonal.Models;

namespace webpersonal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos= ObtenerProyectos().Take(3).ToList();
            var modelo= new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }


        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto {
            Titulo ="Policia Nacional del Perú",
            Descripcion =  "Creacion de un sistema de RR.HH en ASP.NET Core",
            Link ="https://www.policia.gob.pe/sistemaspnp/login.html",
            ImagenURL ="/images/pnp.png"
            },
            new Proyecto {
            Titulo ="SENATI",
            Descripcion =  "Mantenimiento realizado en pagina institucional en ASP.NET Core",
            Link ="https://admision.senati.marketing/",
            ImagenURL ="/images/senati.png"
            },
            new Proyecto {
            Titulo ="Everis",
            Descripcion =  "Landing Page en ASP.NET Core",
            Link ="https://es.nttdata.com/",
            ImagenURL ="/images/everis.png"
            },
            new Proyecto {
            Titulo ="Graña y Montero",
            Descripcion =  "Solucionador de bugs en modulo de GMD service desk en ASP.NET Core",
            Link ="https://www.gymconstructora.com/",
            ImagenURL ="/images/graña.png"
            },
            };
        }

        public IActionResult Privacy()
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