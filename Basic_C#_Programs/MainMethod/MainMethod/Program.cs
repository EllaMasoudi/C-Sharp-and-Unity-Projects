using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            
            Console.WriteLine(sm.Calculate(10));
            Console.WriteLine(sm.Calculate(11));
            Console.WriteLine(sm.Calculate("3"));
           

            Console.ReadLine();

        }
    }
}
