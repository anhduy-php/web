using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class IntroduceController : Controller
    {
        // GET: IntroduceController
        [Route("/introduce")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: IntroduceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IntroduceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntroduceController/Create
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

        // GET: IntroduceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IntroduceController/Edit/5
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

        // GET: IntroduceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IntroduceController/Delete/5
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
