using WebShop.Interfaces;
using System;


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
       // public Dictionary<string, string> PaymentMethods { get; set; }
       // public Dictionary<string, string> Specifications { get; set; }
       // public IEnumerable<string> Pic { get; set; }
       //public ISale SpecialOffer { get; set; }
       // public IEnumerable<string> Categories { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}
