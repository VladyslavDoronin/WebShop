using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Classes;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(new Product()
            {
                Id = 1,
                Name = "Aspirin 2",
                Price = 309,
                URL = "https://Aspririn_2.com",
                isEnabled = true,
                Quantity = 20,
                Description = "good medicine",
                isActive = true,
            });
        }

        public IActionResult add()
        {
            return View();
        }
    }
}