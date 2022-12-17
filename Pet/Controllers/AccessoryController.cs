using Database.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class AccessoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public AccessoryController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: AccessoryController
        [Route("/accessory")]
        public ActionResult Index()
        {
            var products = _context.products;
            return View(products);
        }

        // GET: AccessoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccessoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccessoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccessoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccessoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccessoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
