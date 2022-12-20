using Database.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BillsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: BillsController
        [Route("/management/bills")]
        public ActionResult Index()
        {
            var cartPets = from a in _context.Users
                               join b in _context.bills on a.Id equals b.bill_UserId
                               select new { a, b};
                ViewBag.bills = "";

                var billModel = cartPets.Select(x => new BillsModel()
                {
                    Id = x.b.bill_Id,
                    Name = x.a.Email,
                    Price = x.b.bill_Total,
                    Email = x.a.Email,
                    IsPayment = x.b.bill_StatusPayment,
                    IsReceive = x.b.bill_StatusReviceOrder,
                    Created = x.b.bill_StartDateTime
                });
            ViewBag.Bils = billModel;

            return View();
        }

        // GET: BillsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillsController/Create
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

        // GET: BillsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillsController/Edit/5
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

        // GET: BillsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillsController/Delete/5
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
