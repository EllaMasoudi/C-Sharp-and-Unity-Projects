using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
   public class SimpleMath
    {
       
        
   public int Calculate(int num)
    {
            return num + 1;
           
    }

        public int Calculate(double num)
        {
            return (int)(num - 1);
        }
        public int Calculate(string num)
        {
            return Int32.Parse(num) * 2;
        }




    }
}
