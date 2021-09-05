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
          
            Console.WriteLine("Please enter a number");
           int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now);
                Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
