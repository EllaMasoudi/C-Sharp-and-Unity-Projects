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

            Employee<string> employee1 = new Employee<string>();
            List<string> testList = new List<string>();
            testList.Add("elham");
            testList.Add("ali");
            employee1.Things = testList;

            Employee<int> employee2 = new Employee<int>();
            List<int> SecondList = new List<int>();
            SecondList.Add(1);
            SecondList.Add(2);
            employee2.Things = SecondList;

            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            } 
         foreach(string item in employee1.Things)
            {
                Console.WriteLine(item);
            }




         


            //Employee<T> employee = new Abstract.Employee<T>();

            //Employee employee1 = new Employee("Sample", "Student", 1);
            //Employee employee2 = new Employee("test", "teacher", 1);

            //if (employee1 == employee2)
            //{
            //    Console.WriteLine("they are the same");
            //}
            //else
            //{
            //    Console.WriteLine("they are NOT the same");

            //}

            Console.ReadLine();




        }
    }
}
