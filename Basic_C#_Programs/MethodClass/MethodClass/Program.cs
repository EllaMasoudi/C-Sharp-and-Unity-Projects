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
            int a = 12;
            int b = 6;
            math.Calculate(a, b);
        }
        
    }
}
