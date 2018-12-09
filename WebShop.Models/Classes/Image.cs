using WebShop.Classes;

namespace WebShop.Models.Classes
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual Product Products { get; set; }

    }
}
