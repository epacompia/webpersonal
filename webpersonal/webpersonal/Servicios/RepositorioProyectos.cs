using webpersonal.Models;

namespace webpersonal.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }



    public class RepositorioProyectos:IRepositorioProyectos
    {


        public List<Proyecto> ObtenerProyectos()
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



    }
}
