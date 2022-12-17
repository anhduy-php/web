using Database.Data;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    public class PuppyController : Controller
    {
        private readonly ILogger<PuppyController> _logger;
        private ApplicationDbContext _context;

        public PuppyController(ILogger<PuppyController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: PuppyController
        [Route("/puppy")]
        public ActionResult Index(string search = "")
        {
            if (!string.IsNullOrEmpty(search))
            {
                var petSearch = _context.pets;

                if (petSearch.Any())
                {
                    var petSearchs = petSearch.Where(x => x.pet_Name.Contains(search));
                    var petModel = petSearchs.Select(x => new Pets()
                    {
                       pet_Id = x.pet_Id,
                       pet_Name = x.pet_Name,
                       pet_Description = x.pet_Description,
                       pet_Price = x.pet_Price,
                       pet_ImgUrl1 = x.pet_ImgUrl1,
                       pet_ImgUrl4 = x.pet_ImgUrl4
                    });

                    return View(petModel);
                }
            }
            var pets = _context.pets;
            return View(pets);
        }

        // GET: PuppyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PuppyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuppyController/Create
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

        // GET: PuppyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PuppyController/Edit/5
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

        // GET: PuppyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PuppyController/Delete/5
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
