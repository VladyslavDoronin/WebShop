using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Controllers
{
    public class CatalogController : Controller
    {
        ShopContext _db;

        public CatalogController(ShopContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var prods = _db.Products.Include(x => x.Images)
                .Include(x => x.PaymentMethods)
                .Include(x => x.Specifications)
                .Where(x => x.IsActive == true).ToList();

            return View(prods);
        }


        public IActionResult Products(string url)
        {
            var prod = _db.Products.Include(x => x.Images)
                .Include(x => x.PaymentMethods)
                .Include(x => x.Specifications)
                .Where(x => x.URL == url && x.IsActive == true).FirstOrDefault();

            return View(prod);
        }
    }
}