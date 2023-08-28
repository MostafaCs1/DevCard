using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
