using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hi "+ yourName + ", What course are you on ? ");
        
            string courseName = Console.ReadLine();
            Console.WriteLine("In " + courseName + " What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.");
            bool helpNeeded = Convert.ToBoolean(Console.ReadLine()); 
          
           
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExprience = Console.ReadLine();
         
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
           
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();

        }
    }
}
