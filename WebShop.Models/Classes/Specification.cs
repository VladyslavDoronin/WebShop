using WebShop.Classes;

namespace WebShop.Models.Classes
{
    public class Specification
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }

        public virtual Product Products { get; set; }

    }
}
