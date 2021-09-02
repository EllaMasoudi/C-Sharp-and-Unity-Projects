using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public struct employee
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public employee(string fName, string LName, int Id)
        {
            this.FirstName = fName;
            this.LastName = LName;
            this.Id = Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            List<employee> employees = new List<employee>();

            employees.Add(new employee("Joe", "Johnson", 1));
            employees.Add(new employee("Tom", "Walker", 2));
            employees.Add(new employee("Jim", "Dongoski", 3));
            employees.Add(new employee("Nancy", "Stenner", 4));
            employees.Add(new employee("Ella", "Masoudi", 5));
            employees.Add(new employee("Alie", "Smith", 6));
            employees.Add(new employee("Bella", "Brown", 7));
            employees.Add(new employee("Suzan", "Garcia", 8));
            employees.Add(new employee("Joe", "Williams", 9));
            employees.Add(new employee("Rubin", "Miller", 10));

            List<employee> joeemployees = new List<employee>();

            foreach (employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    joeemployees.Add(e);
                }
            }

            List<employee> lambda_joeemployees = employees.Where(x => x.FirstName == "Joe").ToList();
            List<employee> employee_Id = employees.Where(x => x.Id > 5).ToList();


            Console.ReadLine();
        }


    }


}
