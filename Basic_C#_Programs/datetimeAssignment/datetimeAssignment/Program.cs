using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now);
          
            Console.WriteLine("Please enter a number 0 to 24");
            int userInput = Convert.ToInt32(Console.ReadLine());
            System.TimeSpan tSpan = new System.TimeSpan(userInput, 0,0);
            System.DateTime result = DateTime.Now + tSpan;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
