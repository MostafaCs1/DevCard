using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
