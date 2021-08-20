using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            double weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }



            double width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToInt32(Console.ReadLine());


            double total = length + height + width;
            double cost = height * width * length * weight / 100;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
               
                 Console.WriteLine("Your estimated total for shipping this package is: $" + cost);
                Console.WriteLine("Thank you");
               
            }
            Console.ReadLine();
        }
    }
} 
