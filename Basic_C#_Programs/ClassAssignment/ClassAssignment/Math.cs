using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Math
    {
        public void Calculate(int num, out int result)
            {
           
            result = num /2;

        }

        public void methodWithOutputParameters(out int result1, out int result2)
        {
            result1 = 1;
            result2 = 2;
        }

        public void methodWithOutputParameters(out int result1, out int result2, int x)
        {
            result1 = x;
            result2 = 2;
        }
    }
}
