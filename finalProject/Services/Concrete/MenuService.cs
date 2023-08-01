using System;
using ConsoleTables;
using finalProject.Data.Enums;
using System.Collections.Generic;
using System.Linq;

namespace finalProject.Services.Concrete
{
    public class MenuService 

    {
        private static MarketService marketService = new MarketService();

        // Method to add a new product to the market system
        public static void MenuAddProduct()
        {
            try
            {
                Console.WriteLine("Enter Product's name, please");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Product's price, please");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Available categories:");

                foreach (var item in Enum.GetValues(typeof(Categories)))
                {
                    string Category = Enum.GetName(typeof(Categories), item);
                    Console.WriteLine($"Category: {Category}");
                }

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
                // Gets the list of products
                var products = marketService.GetProducts();

                // Shows available categories
                Console.WriteLine("Available categories:");

                foreach (var item in Enum.GetValues(typeof(Categories)))
                {
                    string Category = Enum.GetName(typeof(Categories), item);
                    Console.WriteLine($"Category: {Category}");
                }

                // user enters the product's category

                Console.WriteLine("Enter Product's category, please");
                Categories category = (Categories)Enum.Parse(typeof(Categories), Console.ReadLine(), true);

                // Filters and shows products of the selected category

                var productsByCategory = products.FindAll(x => x.Category == category);

                if (productsByCategory.Count > 0)
                {
                Console.WriteLine($"Products in the category '{category}':");
                foreach (var product in productsByCategory)
                {
                    Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}");
                }
        }
                else
                {
                    Console.WriteLine($"No products found in the category '{category}'.");
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
                
                int newId = marketService.AddSale(productId, quantity, date);
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
                Console.WriteLine("Enter Sale's ID, please");
                int saleID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Products's ID, please");
                int productID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product's quantity, please");
                int quantity = int.Parse(Console.ReadLine());

                marketService.ReturnOfProduct(saleID, productID, quantity);
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
                int ID = int.Parse(Console.ReadLine());
                marketService.RemoveSales(ID);
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
                var table = new ConsoleTable("saleID", "Amount", "Quantity", "Date");

                foreach (var sale in sales)
                {
                    foreach (var item in sale.Items)
                    {
                        table.AddRow(sale.ID, sale.Amount,item.Quantity, sale.Date);
                        break;
                    }
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
                    Console.WriteLine("Enter minimum date (MM/DD/YYYY):");
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime minDate))
                    {
                        Console.WriteLine(" Please enter the date in the format MM/DD/YYYY.");
                        return;
                    }

                    Console.WriteLine("Enter maximum date (MM/DD/YYYY):");
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime maxDate))
                    {
                        Console.WriteLine("Please enter the date in the format MM/DD/YYYY.");
                        return;
                    }

                    var foundSales = marketService.ShowSalesByDateRange(minDate, maxDate);

                    if (foundSales.Count == 0)
                    {
                        Console.WriteLine("Sales not found in the given range.");
                        return;
                    }

                    foreach (var sale in foundSales)
                    {
                        Console.WriteLine($" Sale Id: {sale.ID} | Amount: {sale.Amount} | Date: {sale.Date}");

                        foreach (var item in sale.Items)
                        {
                            Console.WriteLine($" Id: {item.Product.ID} | Product Name: {item.Product.Name} | Quantity: {item.Quantity}");
                        }
                    }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuShowSalesByPriceRanges()
        {

            {
                try
                {
                    Console.WriteLine("Enter minimum amount:");
                    decimal minAmount = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maximum amount:");
                    decimal maxAmount = decimal.Parse(Console.ReadLine());

                    var foundSales = marketService.ShowSalesByPriceRanges(minAmount, maxAmount);

                    if (foundSales.Count == 0)
                    {
                        Console.WriteLine("No sales found.");
                        return;
                    }

                    foreach (var sale in foundSales)
                    {
                        Console.WriteLine($"Sale ID: {sale.ID} | Date: {sale.Date}");

                        foreach (var saleItem in sale.Items)
                        {
                            Console.WriteLine($"   - Product ID: {saleItem.Product.ID}, Name: {saleItem.Product.Name}, Quantity: {saleItem.Quantity}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Oops, error. {ex.Message}");
                }
            }
        
        }

        public static void MenuShowSalesOnGivenDate()
        {
            try
            {
                Console.WriteLine("Enter the date (MM/DD/YYYY) for which you want to see sales:");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    var foundSales = marketService.ShowSalesByExactDate(date);

                    if (foundSales.Count == 0)
                    {
                        Console.WriteLine("No sales found for the given date.");
                        return;
                    }
                    //shows the details of each sale found for the given date
                    foreach (var sale in foundSales)
                    {
                        Console.WriteLine($"Sale ID: {sale.ID} | Amount: {sale.Amount} | Date: {sale.Date}");

                        // shows the details of each sale item in the sale
                        foreach (var saleItem in sale.Items)
                        {
                            Console.WriteLine($"   - Product ID: {saleItem.Product.ID}, Name: {saleItem.Product.Name}, Quantity: {saleItem.Quantity}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter the date in the format YYYY-MM-DD.");
                }

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
                Console.WriteLine("Enter Sale's ID for search:");
                int ID = int.Parse(Console.ReadLine());

                var foundSale = marketService.FindSalesByGivenID(ID);

                if (foundSale.Count == 0)
                {
                    Console.WriteLine("No sales found.");
                    return;
                }

                foreach (var sale in foundSale)
                {
                    Console.WriteLine($"Sale ID: {sale.ID} | Amount: {sale.Amount} | Date: {sale.Date}");

                    foreach (var saleItem in sale.Items)
                    {
                        Console.WriteLine($"   - Product ID: {saleItem.Product.ID}, Name: {saleItem.Product.Name}, Quantity: {saleItem.Quantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }


    }
}
