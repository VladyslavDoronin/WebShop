using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Classes;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        ShopContext _db;

        public ProductController(ShopContext context)
        {
            _db = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();

            return RedirectToAction("Index", "Catalog");
        }

        public IActionResult Delete(int id)
        {
            _db.Products.Remove(_db.Products.Where(x => x.Id == id).FirstOrDefault());
            _db.SaveChanges();

            return RedirectToAction("Index", "Catalog");

        }

        public IActionResult Edit(string url, int id)
        {
            var prod = _db.Products.Include(x => x.Images)
                .Include(x => x.PaymentMethods)
                .Include(x => x.Specifications)
                .Where(x => x.URL == url && x.Id == id).FirstOrDefault();

            return View(prod);

        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();

            return View(product);
        }
    }
}