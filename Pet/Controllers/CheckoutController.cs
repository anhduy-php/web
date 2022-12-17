using Database.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System.Security.Claims;

namespace Pet.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private ApplicationDbContext _context;

        public CheckoutController(ILogger<CartController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: CheckoutController
        [Route("/checkout")]
        public ActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                var cartPets = from a in _context.Users
                               join b in _context.bills on a.Id equals b.bill_UserId
                               join c in _context.pettInBill on b.bill_Id equals c.pib_BillId
                               join d in _context.pets on c.pib_PetId equals d.pet_Id
                               select new { a, b, c, d };

                double total = 0;
                foreach (var item in cartPets)
                {
                    total = total + item.d.pet_Price * item.c.pib_Quantity;
                }

                var bill = _context.bills.FirstOrDefault(x => x.bill_UserId == userId);
                if (bill != null)
                {
                    bill.bill_Total = total;
                    bill.bill_checkout = true;
                    bill.bill_StartDateTime = DateTime.Now;


                    // Clear Cart
                    var pet = _context.pettInBill.Where(x => x.pib_BillId == bill.bill_Id);
                    if (pet != null)
                    {
                        _context.pettInBill.RemoveRange(pet);
                    }
                }


                
                    

                _context.SaveChanges();
            }

                return View();
        }

        // GET: CheckoutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CheckoutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckoutController/Create
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

        // GET: CheckoutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckoutController/Edit/5
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

        // GET: CheckoutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckoutController/Delete/5
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
