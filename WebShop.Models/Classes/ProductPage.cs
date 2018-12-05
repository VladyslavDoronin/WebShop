using WebShop.Interfaces;
using System.Collections.Generic;


namespace WebShop.Classes
{
    class ProductPage : IProductPage
    {
        public IProduct Product { get; set; }
        //public IEnumerable<IReview> Reviews { get; set; }
        public IEnumerable<IProduct> RelatedProducts { get; set; }
    }
}
