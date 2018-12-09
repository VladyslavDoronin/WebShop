using WebShop.Interfaces;
using System;
using WebShop.Models.Classes;
using System.Collections.Generic;

namespace WebShop.Classes
{
    public class Product : IProduct

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string URL { get; set; }
        public bool IsEnabled { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection <PaymentMethod> PaymentMethods { get; set; }
        public virtual ICollection <Specification> Specifications { get; set; }
    }
}
