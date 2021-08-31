using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Sample", "Student", 1);
            Employee employee2 = new Employee("test", "teacher", 1);

            if (employee1 == employee2)
            {
                Console.WriteLine("they are the same");
            }
            else
            {
                Console.WriteLine("they are NOT the same");

            }

            Console.ReadLine();




        }
    }
}
