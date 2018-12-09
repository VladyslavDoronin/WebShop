﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Catalog()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Index(int id)
        {
            var prod = _db.Products.Include(x => x.Images)
                .Include(x => x.PaymentMethods)
                .Include(x => x.Specifications)
                .Where(x=>x.Id == id).FirstOrDefault();
            if(prod != null)
            {
                var img = prod.Images.FirstOrDefault();
            }
            
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
            _db.SaveChanges();

            return View();
        }
    }
}