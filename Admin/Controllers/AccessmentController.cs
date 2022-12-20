using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Admin.Controllers
{
    public class AccessmentController : Controller
    {
        private readonly ILogger<AccessmentController> _logger;
        public AccessmentController(ILogger<AccessmentController> logger)
        {
            _logger = logger;
        }

        // GET: AccessmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccessmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccessmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessmentController/Create
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

        // GET: AccessmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccessmentController/Edit/5
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

        // GET: AccessmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccessmentController/Delete/5
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
