using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
