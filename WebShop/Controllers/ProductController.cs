using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Catalog()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Index(int id)
        {
            return View(_db.Products.Where(x => x.Id == id).FirstOrDefault());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _db.Products.Add(product);
            _db.Products.Append(product);

            return View();
        }
    }
}