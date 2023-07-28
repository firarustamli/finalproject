using System;
using ConsoleTables;
using finalProject.Data.Enums;

namespace finalProject.Services.Concrete
{
    public class MenuService : MarketService

    {
        private static MarketService marketService = new MarketService();
        
        public static void MenuAddProduct()
        {
            try
            {
                Console.WriteLine("Enter Product's name, please");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Product's price, please");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product's category, please");
                Categories category = (Categories)Enum.Parse(typeof(Categories), Console.ReadLine(), true);


                Console.WriteLine("Enter Product's quantity, please");
                int quantity = int.Parse(Console.ReadLine());

                int newId = marketService.AddProduct(name, price, category, quantity);
                Console.WriteLine($"Product with ID {newId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuUpdateProduct()
        {
            try
            {
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Product's price, please");
                decimal price = decimal.Parse(Console.ReadLine());


                Console.WriteLine("Enter Product's category, please");
                Categories category = (Categories)Enum.Parse(typeof(Categories), Console.ReadLine(), true);


                Console.WriteLine("Enter Product's quantity, please");
                int quantity = int.Parse(Console.ReadLine());


                marketService.UpdateProduct(id, name, price, category, quantity);
               

                Console.WriteLine("Updated student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuRemoveProduct()
        {
            try
            {
                Console.WriteLine("Enter Product's ID, please");
                int id = int.Parse(Console.ReadLine());
                marketService.RemoveProduct(id);
                Console.WriteLine("Product deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowAllProducts()
        {
            try
            {
                var products = marketService.GetProducts();

                if (products.Count == 0)
                {
                    Console.WriteLine("There are no products");
                    return;
                }
                var table = new ConsoleTable("ID", "Name", "Price", "Category", "Quantity");

                foreach (var product in products)
                {
                    table.AddRow(product.ID, product.Name, product.Price, product.Category, product.Quantity);
                }
                table.Write();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }

        }

        public static void MenuShowProductsByCategory()
        {
            try
            {
                var categories = marketService.GetProducts();
                foreach (var item in Enum.GetValues(typeof(Categories)))
                {
                    string Category = Enum.GetName(typeof(Categories), item);
                    Console.WriteLine($"Category: {Category}");
                }

                Console.WriteLine("Enter Product's category, please");
                Categories category = (Categories)Enum.Parse(typeof(Categories), Console.ReadLine(), true);

                foreach (var product in categories)
                {
                    Console.WriteLine($"ID:{product.ID} | Name: {product.Name} | Price: {product.Price} | Quantity: {product.Quantity}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }

        }

        public static void MenuShowProductsByPriceRanges()
        {
            try
            {
                Console.WriteLine("Enter minimum price :");
                decimal minPrice =  decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter maximum price :");
                decimal maxPrice = decimal.Parse(Console.ReadLine());

                var foundProducts = marketService.ShowProductsByPriceRanges(minPrice,maxPrice);

                if (foundProducts.Count == 0)
                {
                    Console.WriteLine("No products found.");
                    return;
                }

                foreach (var product in foundProducts)
                {
                    Console.WriteLine($"Id: {product.ID} | Name: {product.Name} | Price: {product.Price} | Category: {product.Category} | Quantity: {product.Quantity}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuFindProductByName()
        {
            try
            {
                Console.WriteLine("Enter name for search:");
                string name = Console.ReadLine();

                var foundProducts = marketService.FindProductByName(name);

                if (foundProducts.Count == 0)
                {
                    Console.WriteLine("No products found.");
                    return;
                }

                foreach (var product in foundProducts)
                {
                    Console.WriteLine($"Id: {product.ID} | Name: {product.Name} | Price: {product.Price} | Category: {product.Category} | Quantity: {product.Quantity}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }




        // Operations on Sales

        public static void MenuAddSale()
        {
            try
            {
                Console.WriteLine("Enter Product's ID, please");
                int productId = int.Parse(Console.ReadLine());
              
                Console.WriteLine("Enter Product's quantity, please");
                int quantity = int.Parse(Console.ReadLine());
                DateTime date = DateTime.Now;

                int newId = marketService.AddSale(productId,quantity,date);
                Console.WriteLine($"Sale with ID {newId} was created!");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuReturnOfProduct()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuRemoveSale()
        {
            try
            {
                Console.WriteLine("Enter Sale's ID, please");
                int id = int.Parse(Console.ReadLine());
                marketService.RemoveSales(id);
                Console.WriteLine("Sale deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowAllSales()
        {
            try
            {
                var sales = marketService.GetSales();

                if (sales.Count == 0)
                {
                    Console.WriteLine("There are no sales");
                    return;
                }
                var table = new ConsoleTable("ID", "Amount", "SaleItem", "Date");

                foreach (var sale in sales)
                {
                    table.AddRow(sale.ID, sale.Amount,sale.SalesItem,sale.Date);
                }
                table.Write();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowSalesByDateRange()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowSalesByPriceRanges()
        {
            try
            {
                Console.WriteLine("Enter minimum amount :");
                decimal minAmount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter maximum amount :");
                decimal maxAmount = decimal.Parse(Console.ReadLine());

                var foundSales = marketService.ShowSalesByPriceRanges(minAmount, maxAmount);

                if (foundSales.Count == 0)
                {
                    Console.WriteLine("No sales found.");
                    return;
                }

                foreach (var sale in foundSales)
                {
                    Console.WriteLine($"ID: {sale.ID} | SaleItem : {sale.SalesItem} | Date: {sale.Date}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowSalesOnGivenDate()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuFindSalesByGivenID()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }


    }
}
