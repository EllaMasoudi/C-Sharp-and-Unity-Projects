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
