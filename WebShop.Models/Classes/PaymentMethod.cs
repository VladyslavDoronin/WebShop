using WebShop.Classes;

namespace WebShop.Models.Classes
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NameOfMethod { get; set; }

        public virtual Product Products { get; set; }
    }
}
