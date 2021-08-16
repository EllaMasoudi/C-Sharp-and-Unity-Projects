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



            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            int hourlyRateP1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Hours worked per week? ");
            int hoursPerWeekP1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            int hourlyRateP2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week? ");
            int hoursPerWeekP2 = Convert.ToInt32(Console.ReadLine());

            int AnnualSalaryP1 = hourlyRateP1 * hoursPerWeekP1 * 52;
            int AnnualSalaryP2 = hourlyRateP2 * hoursPerWeekP2 * 52;


            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(AnnualSalaryP1);
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(AnnualSalaryP2);

            bool moreSalary = AnnualSalaryP1 > AnnualSalaryP2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreSalary);


            Console.ReadLine();
        }
    }
}
