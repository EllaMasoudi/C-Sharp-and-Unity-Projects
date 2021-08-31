using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
  public  class Employee: Person, IQuittable
    {
        
        
        public int Id;
       

        public static Boolean operator ==(Employee e1, Employee e2)
        {
            if (e1.Id == e2.Id)
            {
                return true;
            }
            return false;
        }

        public static Boolean operator !=(Employee e1, Employee e2)
        {
            if (e1.Id == e2.Id)
            {
                return false;
            }
            return true;
        }
        public Employee(string fname, string lname, int id)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Id = id;
        }
        
        
        public override void sayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            
        }
        public void Quit()
        {
            Console.WriteLine("quit is called");

        }


    }
    
}
