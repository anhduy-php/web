using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class RaiseController : Controller
    {
        // GET: RaiseController
        [Route("/raise")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: RaiseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RaiseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaiseController/Create
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

        // GET: RaiseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RaiseController/Edit/5
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

        // GET: RaiseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RaiseController/Delete/5
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
