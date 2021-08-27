using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number for math operation:It will add, multiply and subtract 1 to your number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Calculate cal = new Calculate();
            Console.WriteLine(cal.AddOne(userInput));
            Console.WriteLine(cal.MultiplyOne(userInput));
            Console.WriteLine(cal.SubtractOne(userInput));

            Console.ReadLine();

        }
    }
}
