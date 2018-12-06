using System;
using System.Collections.Generic;

namespace WebShop.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string URL { get; set; }
        bool isEnabled { get; set; }
        int Quantity { get; set; }
        string Description { get; set; }
        Dictionary<string, string> PaymentMethods { get; set; }  //ключ, характеристика
        Dictionary<string, string> Specifications { get; set; } //ключ, характеристика
        IEnumerable<string> Pic { get; set; }
        IEnumerable<string> Categories { get; set; }  //список категорий, к которым он пренадлежит
        bool isActive { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        int UpdatedBy { get; set; } //id сотрудника

    }
}
