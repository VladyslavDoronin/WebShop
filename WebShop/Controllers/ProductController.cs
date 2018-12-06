using System.Collections.Generic;
using WebShop.Classes;
using WebShop.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public IActionResult Index()
        {
            return View(new Product()
            {
                Id = 1,
                Name = "Spazmalgon",
                Price = 10,
                URL = "https://www.google.com.ua/search?q=spazmalgon&oq=spazmalgon",
                isEnabled = true,
                Quantity = 5,
                Description = "Drink with headaches",
                isActive = true ,
                UpdatedBy = 1,

            });

        }

      
        
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View(new Product()
            {
                Id = 1,
                Name = "Spazmalgon",
                Price = 10,
                URL = "https://www.google.com.ua/search?q=spazmalgon&oq=spazmalgon",
                isEnabled = true,
                Quantity = 5,
                Description = "Drink with headaches",
                isActive = true,
                UpdatedBy = 1,

            });
        }

    }
}