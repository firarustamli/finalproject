using System;
using finalProject.Data.Common;
using finalProject.Data.Enums;

namespace finalProject.Data.Models
{
    public class Product : BaseEntity
    {
        private static int count = 0;

        public Product(string name,decimal price,Categories category,int quantity)
        {
            Name = name;
            Price = price;
            Category = category;
            Quantity = quantity;

            ID = count;
            count++;

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Categories Category { get; set; }
        public int Quantity { get; set; }
        

    }
}
