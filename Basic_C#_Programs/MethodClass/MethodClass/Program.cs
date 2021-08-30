using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Calculate(3,1);
            
            math.Calculate(num1:10, num2: 2);
            Console.ReadLine();
        }
        
        
    }
}
