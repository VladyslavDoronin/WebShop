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
                Name = "Ibuprofen",
                Price = 210
            });
        }

        public IActionResult addNewProduct()
        {
            return View(new Product()
            {
                Name = "Analgin",
                Price = 11
            });
        }
    }
}