using System;
using finalProject.Helpers;

namespace finalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int option;


            do
            {

                Console.WriteLine("1. Operation on Products");
                Console.WriteLine("2. Operation on Sales");
                Console.WriteLine("3. Exit");
               

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Enter an option please:");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option!");
                    Console.WriteLine("Enter an option please:");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                }


                switch (option)
                {
                    case 1:
                        SubMenu.ProductsSubMenu();
                       
                        break;
                    case 2:
                        SubMenu.SalesSubMenu();
                        break;
                       
                    case 3:
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }

            } while (option != 0);
        }
    }
}
