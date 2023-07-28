using System;
using System.Collections.Generic;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class Sales : BaseEntity
    {
        private static int count = 0;

        public Sales(decimal amount, List<SalesItem> salesItem,DateTime date)
        {
            Amount = amount;
            List<SalesItem> SalesItem = salesItem;
            Date = date;
            ID = count;
            count++;

           
        }
        public decimal Amount { get; set; }
        public List<SalesItem> SalesItem { get; set; }
        public DateTime Date { get; set; }

       

    }
}
