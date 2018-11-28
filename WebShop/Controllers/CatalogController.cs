using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaces;
using interfaces.Classes;
using interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View(new Catalog() {
                ProductList = new List<IProduct>()
                { new Product()
                { Name = "Aspirin", Price = 3}
                } });
        }
    }
}