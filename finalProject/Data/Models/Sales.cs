using System;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class Sales : BaseEntity
    {
        private static int count = 0;

        public Sales(decimal amount,SalesItem salesItem,DateTime date)
        {
            Amount = amount;
            SalesItem = salesItem;
            Date = date;

            ID = count;
            count++;

        }
        public decimal Amount { get; set; }
        public SalesItem SalesItem { get; set; }
        public DateTime Date { get; set; }



    }
}
