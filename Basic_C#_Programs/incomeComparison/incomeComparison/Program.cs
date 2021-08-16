using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            int hourlyRateP1 = 15;
            int hoursPerWeekP1 = 40;
            int hourlyRateP2 = 20;
            int hoursPerWeekP2 = 40;

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            Console.WriteLine(hourlyRateP1);
            Console.WriteLine("Hours worked per week? ");
            Console.WriteLine(hoursPerWeekP1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            Console.WriteLine(hourlyRateP2);
            Console.WriteLine("Hours worked per week? " );
            Console.WriteLine(hoursPerWeekP2);
      
            int AnnualSalaryP1 = hourlyRateP1 * hoursPerWeekP1 * 52;
            int AnnualSalaryP2 = hourlyRateP2 * hoursPerWeekP2 * 52;


            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(AnnualSalaryP1);
            Console.WriteLine("Annual salary of Person 2: " );
            Console.WriteLine(AnnualSalaryP2);
            
            bool moreSalary = AnnualSalaryP1 > AnnualSalaryP2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreSalary);


            Console.ReadLine();
        }
    }
}
