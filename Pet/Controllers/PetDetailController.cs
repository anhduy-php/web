using Database.Data;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using System.Security.Claims;

namespace Pet.Controllers
{
    public class PetDetailController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public PetDetailController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: PetDetailController
        [Route("/petdetail")]
        public ActionResult Index(string id)
        {
            var pet = _context.pets.FirstOrDefault(x => x.pet_Id == id);
            return View(pet);
        }

        // GET: PetDetailController/Details/5
        public ActionResult AddPetCart(string id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Check Bill
            var bill = _context.bills.FirstOrDefault(x => x.bill_UserId == userId);
            Bills bills = null;

            if (bill == null)
            {
                bills = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_UserId = userId,
                    bill_StatusPayment = false,
                    bill_Total = 0,
                    bill_StatusReviceOrder = false,
                    bill_StartDateTime = DateTime.Now,
                    bill_checkout = false,
                    bill_Cancel = false
                };

                _context.bills.Add(bills);

                var petInBill = _context.pettInBill.FirstOrDefault(x => x.pib_BillId == bills.bill_Id && x.pib_PetId == id);
                if (petInBill != null)
                {
                    petInBill.pib_Quantity++;
                }
                else
                {
                    PettInBill pettInBill = new PettInBill()
                    {
                        pib_PetId = id,
                        pib_BillId = bills.bill_Id,
                        pib_Quantity = 1,
                    };
                    _context.pettInBill.Add(pettInBill);
                }
                
            }
            else
            {
                
                var petInBill = _context.pettInBill.FirstOrDefault(x => x.pib_BillId == bill.bill_Id && x.pib_PetId == id);
                if (petInBill != null)
                {
                    petInBill.pib_Quantity++;
                }
                else
                {
                    PettInBill pettInBill = new PettInBill()
                    {
                        pib_PetId = id,
                        pib_BillId = bill.bill_Id,
                        pib_Quantity = 1,
                    };
                    _context.pettInBill.Add(pettInBill);
                }
                

            }
            
            

            _context.SaveChanges();

            return Redirect("/cart");
        }

        // GET: PetDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetDetailController/Create
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

        // GET: PetDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetDetailController/Edit/5
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

        // GET: PetDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetDetailController/Delete/5
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
