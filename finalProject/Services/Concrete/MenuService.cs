using System;
using ConsoleTables;
using finalProject.Data.Enums;

namespace finalProject.Services.Concrete
{
    public class MenuService

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

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }




        // Operations on Sales

        public static void MenuAddPSale()
        {
            try
            {

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
