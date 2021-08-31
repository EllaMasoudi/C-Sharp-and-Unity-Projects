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

            int num = Convert.ToInt32(Console.ReadLine());

            int j;
            math.Calculate(num, out j);

            Console.WriteLine(j);

            Console.WriteLine("This is the result of a static class:" + StaticClass.Addition(2, 3));


            Console.ReadLine();

        }
    }
}
