using System;
using System.Collections.Generic;
using finalProject.Data.Enums;
using finalProject.Data.Models;
using finalProject.Services.Abstract;

namespace finalProject.Services.Concrete
{
    public class MarketService : IMarketable

    {
        private List<Product> products;
        private List<Sales> sales;
        private List<SalesItem> salesItems;


        public MarketService()
        {
            products = new List<Product>();
            sales = new List<Sales>();
            salesItems = new List<SalesItem>();

        }

        public int AddProduct(string name, decimal price, Categories category, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (price < 0) throw new Exception("Price can't be less than 0!");
            if (quantity < 0) throw new Exception("Quantity can't be less than 0!");

            var product = new Product(name, price, category, quantity);
            products.Add(product);
            return product.ID;
        }

        public int AddSale(decimal amount, SalesItem salesItem, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Product> FindProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Sales> FindSalesByGivenID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Sales> GetSales()
        {
            throw new NotImplementedException();
        }

        public void MenuRemoveSale(int ID)
        {
            throw new NotImplementedException();
        }

        public void ReturnOfProduct(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductsByCategory(Categories category)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductsByPriceRanges(decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public List<Sales> ShowSalesByDateRange(DateTime minDate, DateTime maxDate)
        {
            throw new NotImplementedException();
        }

        public List<Sales> ShowSalesByExactDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Sales> ShowSalesByPriceRanges(decimal minAmount, decimal maxAmount)
        {
            throw new NotImplementedException();
        }

        public List<Product> UpdateProduct(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
