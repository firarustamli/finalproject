using System;
using finalProject.Services.Concrete;

namespace finalProject.Helpers
{
    public class SubMenu
    {

        public static void ProductsSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Show all Products");
                Console.WriteLine("5. Show products by category");
                Console.WriteLine("6. Show products by price ranges");
                Console.WriteLine("7. Find product by name");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuAddProduct();

                     break;

                    case 2:
                        MenuService.MenuUpdateProduct();
                        break;

                    case 3:
                        MenuService.MenuRemoveProduct();
                        break;

                    case 4:
                        MenuService.MenuShowAllProducts();
                        break;

                    case 5:
                        MenuService.MenuShowProductsByCategory();
                        break;

                    case 6:
                        MenuService.MenuShowProductsByPriceRanges();
                        break;
                        
                    case 7:
                        MenuService.MenuFindProductByName();

                        break;

                    case 0:

                        break;

                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);
        }

       
        public static void SalesSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add Sale");
                Console.WriteLine("2. Return of Product");
                Console.WriteLine("3. Remove Sale");
                Console.WriteLine("4. Show all Sales");
                Console.WriteLine("5. Show sales by date range");
                Console.WriteLine("6. Show sales by price ranges");
                Console.WriteLine("7. Show sales on given date");
                Console.WriteLine("8. Find Sales by given ID");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuAddSale();

                        break;
                    case 2:
                        MenuService.MenuReturnOfProduct();
                        break;
                    case 3:
                        MenuService.MenuRemoveSale();
                        break;
                    case 4:
                        MenuService.MenuShowAllSales();
                        break;
                    case 5:
                        MenuService.MenuShowSalesByDateRange();
                        break;
                    case 6:
                        MenuService.MenuShowSalesByPriceRanges();
                        break;
                    case 7:
                        MenuService.MenuShowSalesOnGivenDate();
                        break;
                    case 8:
                        MenuService.MenuFindSalesByGivenID();
                        break;
                    case 0:

                        break;

                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);

        }
    }
}