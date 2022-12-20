using Database.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet.Models;
using System.Security.Claims;

namespace Pet.Controllers
{
    public class BillController : Controller
    {

        private readonly ILogger<CartController> _logger;
        private ApplicationDbContext _context;

        public BillController(ILogger<CartController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: BillController
        [Route("/bill")]
        public ActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                var cartPets = from a in _context.Users
                               join b in _context.bills on a.Id equals b.bill_UserId
                               where a.Id == userId
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
                return View(billModel);
            }


            return NotFound();
        }

        // GET: BillController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillController/Create
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

        // GET: BillController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillController/Edit/5
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

        // GET: BillController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillController/Delete/5
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
