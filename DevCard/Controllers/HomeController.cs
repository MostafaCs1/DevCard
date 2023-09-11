using Microsoft.AspNetCore.Mvc;
using DevCard.Models;

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

        [HttpGet]
        [Route("[action]")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Contact(ContactFormModel form)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
