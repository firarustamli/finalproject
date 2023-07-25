using System;
using System.Collections.Generic;
using finalProject.Data.Enums;
using finalProject.Data.Models;

namespace finalProject.Services.Abstract
{
    public interface IMarketable
    {
         List<Product> GetProducts();
       int AddProduct(string name, decimal price, Categories category, int count);
       void ReturnOfProduct(int ID);
       void UpdateProduct(int ID);
       void ShowProductsByCategory(Categories category);
       void ShowProductsByPriceRanges(decimal minPrice,decimal maxPrice);
       void FindProductByName(string name);



        List<Sales> GetSales();
        int AddSale(decimal amount, SalesItem salesItem, DateTime date);
        void MenuRemoveSale(int ID);
        void ShowSalesByDateRange(DateTime minDate, DateTime maxDate);
        void ShowSalesByPriceRanges(decimal minAmount,decimal maxAmount);
        void FindSalesByGivenID(int ID);
        

    }
}