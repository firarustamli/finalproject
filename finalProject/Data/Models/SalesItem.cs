using System;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class SalesItem : BaseEntity
    {
        // to generate unique ID.
        private static int count = 0;

        public SalesItem(Product product, int quantity)
        {
            Quantity = quantity;
            //Sets Product property of the SalesItem to the provided product.
            Product = product;
            // Sets the ID to a unique value using count and then increment the count.
            ID = count;
            count++;

        }

        public int Quantity { get; set; }
        public Product Product { get; set; }
        
    }
}
