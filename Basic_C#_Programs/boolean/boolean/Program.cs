using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many legs spiders have?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;
            do
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("No.More than 4 legs!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("No.More than 6 legs!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
             
            Console.ReadLine();
        }
    }
}