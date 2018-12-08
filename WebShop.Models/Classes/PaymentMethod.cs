using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Classes;

namespace WebShop.Models.Classes
{
    class PaymentMethod
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        public string NameOfMethod { get; set; }
    }
}
