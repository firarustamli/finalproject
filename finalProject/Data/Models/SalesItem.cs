using System;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class SalesItem : BaseEntity
    {
        private static int count = 0;

        public SalesItem(int quantity,Product product)
        {
            Quantity = quantity;
            Product = product;
            ID = count;
            count++;

        }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        
    }
}
