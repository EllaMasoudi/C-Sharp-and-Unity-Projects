using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumAssignment
{
    public enum Weekdays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednsday,
        Thursday,
        Friday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            String UserInput = Console.ReadLine();
            bool Done = false;
            while (!Done)
            {


                try
                {

                    Weekdays today = (Weekdays)Enum.Parse(typeof(Weekdays), UserInput);
                    Console.WriteLine(today);
                    Done = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }

                //foreach (string dayName in Enum.GetNames(typeof(Weekdays)))
                //{
                //    Console.WriteLine("{0} = {1:D}", dayName,
                //                                 Enum.Parse(typeof(Weekdays), dayName));
                //}
                UserInput = Console.ReadLine();
            }
            Console.ReadLine();

        }
    }


}
