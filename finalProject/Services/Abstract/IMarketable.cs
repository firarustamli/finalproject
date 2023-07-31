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
        void UpdateProduct(int ID, string name, decimal price, Categories category, int quantity);
        void RemoveProduct(int ID);
        List<Product> ShowProductsByCategory(Categories category);
        List<Product> ShowProductsByPriceRanges(decimal minPrice, decimal maxPrice);
        List<Product> FindProductByName(string name);



        List<Sales> GetSales();
        int AddSale(int productId, int quantity, DateTime date);
        void ReturnOfProduct(int saleID, int productID, int quantity);
        List<Sales> ShowSalesByDateRange(DateTime minDate, DateTime maxDate);
        List<Sales> ShowSalesByExactDate(DateTime date);
        List<Sales> ShowSalesByPriceRanges(decimal minAmount, decimal maxAmount);
        List<Sales> FindSalesByGivenID(int ID);
        void RemoveSales(int ID);

    }
}