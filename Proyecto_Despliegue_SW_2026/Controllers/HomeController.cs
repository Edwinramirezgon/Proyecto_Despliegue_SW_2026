using Proyecto_Despliegue_SW_2026.Models;

namespace Proyecto_Despliegue_SW_2026.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/hello")]
        public IActionResult Hello()
        {
            return Content("Nuevo mensaje desde la corrección conflicto rama desktop 2");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}