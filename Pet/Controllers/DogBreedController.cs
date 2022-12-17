using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class DogBreedController : Controller
    {
        // GET: DogBreedController
        [Route("/dogbreed")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: DogBreedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DogBreedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogBreedController/Create
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

        // GET: DogBreedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DogBreedController/Edit/5
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

        // GET: DogBreedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogBreedController/Delete/5
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
