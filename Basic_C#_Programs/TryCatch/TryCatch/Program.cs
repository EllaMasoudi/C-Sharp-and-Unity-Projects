using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program emerged from try/catch block");
            try {
                List<int> numbers = new List<int>();
                numbers.Add(3);
                numbers.Add(7);
                numbers.Add(2);
                numbers.Add(9);
                Console.WriteLine("Please pick a number to devide each number in the list:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numbers)
                { 
                    Console.WriteLine(num / userNumber); 
                }
                    
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();

            }
            Console.WriteLine("This is the end of the program that emerged from try/catch block");

        }
    }
}
