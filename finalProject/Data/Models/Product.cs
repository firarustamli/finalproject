using System;
using finalProject.Data.Enums;

namespace finalProject.Data.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Categories Category { get; set; }
        public int Count { get; set; }

    }
}
