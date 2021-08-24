using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = new string[] { "You picked pasta", "You picked Chicken", "You picked Steak", "You picked Veggies" };
           

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please enter your the number of your favorite food: \n 0-pasta \n 1-Chicken \n 2-Steak \n 3-Veggies");
                int index = Convert.ToInt32(Console.ReadLine());
                if (0 <= index && index <  food.Length)
                {
                    Console.WriteLine(food[index]);
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please select an index between 0 and " + food.Length);
                }


            }


            int[] tip = new int[] {10, 15, 20, 25 };
            Console.WriteLine("Please enter how much tip you will put for your food:\n 0-$10 \n 1-$15 \n 2-$20 \n 3-$25");
            int tipCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You will pay $"+tip[tipCost]+" for tip");

            List<string> intList = new List<string>();
            intList.Add("You picked Fair");
            intList.Add("You picked Good");
            intList.Add("You picked Very Good");
            intList.Add("You picked Excellent");
            Console.WriteLine("How was your food? Please select the number: \n 0-Fair \n 1-Good \n 2-Very Good \n 3-Excellent");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[rate] + " Thank you for your feedback!");

            Console.ReadLine();
        }
    }
}
