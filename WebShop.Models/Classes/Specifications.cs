﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Classes;

namespace WebShop.Models.Classes
{
    class Specifications
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
    }
}