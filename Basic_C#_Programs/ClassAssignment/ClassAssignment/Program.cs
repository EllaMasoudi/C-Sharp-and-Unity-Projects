using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int r;
            int j = 5;
            math.Calculate(userInput, out j);
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}
