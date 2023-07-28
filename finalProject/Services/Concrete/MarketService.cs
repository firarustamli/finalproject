using System;
using System.Collections.Generic;
using System.Linq;
using finalProject.Data.Enums;
using finalProject.Data.Models;
using finalProject.Services.Abstract;

namespace finalProject.Services.Concrete
{
    public class MarketService : IMarketable

    {
        private List<Product> products;
        private List<Sales> sales;
        private List<SalesItem> salesItem;


        public MarketService()
        {
            products = new List<Product>();
            sales = new List<Sales>();
            salesItem = new List<SalesItem>();
            
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

        public int AddSale(int productId,int quantity,DateTime date)
        {
            if (productId < 0) throw new Exception("Product ID can't be less than 0!");
            if (quantity < 0) ;

            // temp list of saleitems

            var product = products.Find(x => x.ID == productId);
            if (product == null) throw new Exception("Product not found!");



            var saleItem = new SalesItem(product, quantity);
            salesItem.Add(saleItem);
            var sum = product.Price * quantity;
            date = DateTime.Now;
            var sale = new Sales(sum, saleItem, date);
            sales.Add(sale);

            // axirda create sale and append list of saletimes to new sale
            return sale.ID;


        }

        public List<Product> FindProductByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");

            var foundProducts = products.Where(x => x.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();

            return foundProducts;
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
            return sales;
        }

        public void RemoveProduct(int ID)
        {
            if (ID < 0) throw new Exception("ID can't be less than 0!");
            int ProductIndex = products.FindIndex(x => x.ID == ID);
            if (ProductIndex == -1) throw new Exception("product not found");
            products.RemoveAt(ProductIndex); 
        }

        public void RemoveSales(int ID)
        {
            if (ID < 0) throw new Exception("ID can't be less than 0!");
            int SaleIndex = sales.FindIndex(x => x.ID == ID);
            if (SaleIndex == -1) throw new Exception("sale not found");
            products.RemoveAt(SaleIndex);
        }

        public void ReturnOfProduct(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductsByPriceRanges(decimal minPrice, decimal maxPrice)
        {
            if (minPrice > maxPrice) throw new Exception("Min price can't be more than Max price!");

            return products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
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
            if (minAmount > maxAmount) throw new Exception("Min amount can't be more than Max amount!");

            return sales.Where(x => x.Amount >= minAmount && x.Amount <= maxAmount).ToList();
        }

        public void UpdateProduct(int ID,string name, decimal price, Categories category, int quantity)

        {
            if (ID < 0) throw new Exception("ID can't be less than 0!");
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (price < 0) throw new ArgumentOutOfRangeException("Price can't be less than 0!");
            if (quantity < 0) throw new Exception("Quantity can't be less than 0!");

            var product = products.FirstOrDefault(x => x.ID == ID);

            if (product == null) throw new Exception("Product not found!");

            product.Name = name;
            product.Price = price;
            product.Category = category;
            product.Quantity = quantity;
            
        }

        public List<Product> UpdateSale(int ID, string name, decimal price, Categories category, int quantity)
        {
            throw new NotImplementedException();
        }

       

       
        public List<Product> ShowProductsByCategory(Categories category)
        {
            throw new NotImplementedException();
        }
    }
}
