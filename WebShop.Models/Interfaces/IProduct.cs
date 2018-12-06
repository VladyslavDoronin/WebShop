using System;


namespace WebShop.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string URL { get; set; }
        bool IsEnabled { get; set; }
        int Quantity { get; set; }
        string Description { get; set; }
        //Dictionary<string, string> PaymentMethods { get; set; }  //ключ, характеристика
        //Dictionary<string, string> Specifications { get; set; } //ключ, характеристика
        //IEnumerable<string> Pic { get; set; }
        bool IsActive { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        int UpdatedBy { get; set; } //id сотрудника

    }
}
