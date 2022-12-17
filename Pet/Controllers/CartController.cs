using Database.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet.Models;
using System.Security.Claims;

namespace Pet.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private ApplicationDbContext _context;

        public CartController(ILogger<CartController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: CartController
        [Route("/cart")]
        public ActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                var cartPets = from a in _context.Users 
                           join b in _context.bills on a.Id equals b.bill_UserId
                           join c in _context.pettInBill on b.bill_Id equals c.pib_BillId
                           join d in _context.pets on c.pib_PetId equals d.pet_Id
                           select new { a,b,c,d };
                ViewBag.cartPet = "";
                if (cartPets.Any())
                {
                    var cartPetModel = cartPets.Select(x => new CartPetModel()
                    {
                        Id = x.d.pet_Id,
                        Name = x.d.pet_Name,
                        Price = x.d.pet_Price,
                        UrlImg1 = x.d.pet_ImgUrl1
                    });
                    ViewBag.cartPet = cartPetModel;
                }
               
                var cartProducts = from a in _context.Users
                              join b in _context.bills on a.Id equals b.bill_UserId
                              join c in _context.productInBill on b.bill_Id equals c.proib_BillId
                              join d in _context.products on c.proib_ProductId equals d.product_Id
                              select new { a, b, c, d };
                ViewBag.cartProduct = "";
                if (cartProducts.Any())
                {
                    var cartProductModel = cartProducts.Select(x => new CartPetModel()
                    {
                        Id = x.d.product_Id,
                        Name = x.d.product_Name,
                        Price = x.d.product_Price
                    });

                    ViewBag.cartProduct = cartProducts;
                }

                

                return View();
            }


            return NotFound();
        }

        // GET: CartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
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
