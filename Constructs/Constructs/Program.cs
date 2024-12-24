using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;

            Console.WriteLine("Number1: " + number1);

            if (number1 >= 10)
            {
                Console.WriteLine("Number1 is greater than or equal to 10");
            }
            else
            {
                Console.WriteLine("Number1 is less than 10");
            }

            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            if(username == "admin" && password == "1234")
            {
                Console.WriteLine("Successfully Logged in");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

            string fav_dish = "Biryani";

            switch (fav_dish)
            {
                case "Chicken Karahi":
                    Console.WriteLine("You Like chicken Karahi");
                    break;
                case "Tandoori Karahi":
                    Console.WriteLine("You like Tandoori Karahi");
                    break;
                case "Biryani":
                    Console.WriteLine("You like Biryani");
                    break;
                default:
                    Console.WriteLine("You Like everything");
                    break;
            }

            Console.ReadKey();
        }
    }
}
