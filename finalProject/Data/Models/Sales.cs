using System;
using System.Collections.Generic;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class Sales : BaseEntity
    {
        private static int count = 0;

        public Sales(decimal amount, int quantity, DateTime date)
        {
            Amount = amount;
            Date = date;
            Quantity = quantity;
            Items = new List<SalesItem>();

            ID = count;
            count++;


        }


        public Sales(decimal amount, List<SalesItem> items,DateTime date)
        {
            Amount = amount;
            Items = items;
            Date = date;
            ID = count;
            count++;
        }
        public decimal Amount { get; set; }
        public List<SalesItem> Items { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public void AddSaleItem(SalesItem saleitem )

        {
            Items.Add(saleitem);
        }
       
    }
}
