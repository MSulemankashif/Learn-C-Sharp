using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Building Calculator----");
            Console.Write("Enter Your first number ");
            int number1 = Convert.ToInt16(Console.ReadLine());


            Console.Write("Enter Your second number ");
            int number2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Your Sum is : ");
            Console.Write(number1 + number2);
            Console.ReadKey();
        }
    }
}
