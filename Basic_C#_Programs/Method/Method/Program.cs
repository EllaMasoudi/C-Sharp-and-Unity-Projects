using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();
            Console.WriteLine(math.Calculate(userInput));

            Console.WriteLine("You can enter the second number for a math operation(you don't have to enter the second number ,it is optional");
            string secondInput = Console.ReadLine();

            if (secondInput!= "")
            {
              int  UsersecondInput = Convert.ToInt32(secondInput);
                Console.WriteLine(math.Calculate(UsersecondInput));
            }
            else
            {
                Console.WriteLine(math.Calculate(userInput));
            }
      
            Console.ReadLine();
           

            //if (2ndInput != ''){
            //    int 2ndUserInput = Convert.ToInt32(2ndInput);
            //}
            //Console.WriteLine(userInput);
            //Math math = new Math();
            //Console.WriteLine(math.Calculate(userInput));
        }
    }
}
