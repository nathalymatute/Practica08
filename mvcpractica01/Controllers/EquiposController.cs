using Microsoft.AspNetCore.Mvc;

namespace mvcpractica01.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
