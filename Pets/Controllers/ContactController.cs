using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
    public class ContactController : Controller
    {
        [Route("/contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
