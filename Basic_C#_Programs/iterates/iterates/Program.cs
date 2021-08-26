using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] food = { "food", "home", "city", "family" };
            Console.WriteLine("Please add a word for this list:  \n food \n home \n city \n family ");
            string favFood = Console.ReadLine();
            for (int i = 0; i < food.Length; i++)
            {

                Console.WriteLine("I have a " + favFood + food[i]);
            }

            //End of the part one

            //Part two, infinite loop:

          bool willContinue = false;
            while (willContinue== false)
                    {
                Console.WriteLine("Fixed infinit loop \n");
                willContinue = true;
            }


            //Part three < and <= operator
            int[] belonging = { 1, 2, 3, 4 };
            Console.WriteLine("How many cars do you have? \n 1, 2, 3 or 4");

            int car = Convert.ToInt32(Console.ReadLine());

            if (car < 2 )
            {
                Console.WriteLine("You can buy more cars!");
            }



            int[] houses = { 1, 2, 3, 4 };
            Console.WriteLine("How many houses do you have? 1, 2, 3, or 4");
            int house = Convert.ToInt32(Console.ReadLine());

            if(house <= 1)
            {
                Console.WriteLine("You can  buy a house!");
            }
            else
            {
                Console.WriteLine("You have enough houses!");
            }

            //part 4 list of strings
           
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Lion");
            animals.Add("Camel");
            animals.Add("Zebra");
            bool done = false;
            Console.WriteLine("Please select an animal from the list: Cat, Dog, Lion, Camel, Zebra");

            while (!done)
            {
                string favAnimal = Console.ReadLine();

                for (int i = 0; i < animals.Count; i++)
                {
                    if (favAnimal == animals[i])
                    {
                        Console.WriteLine("Your favorite animal is " + i);
                        done = true;
                        break;
                    }
                }

                if (done != true)
                {
                    Console.WriteLine("Please select a name from the list");
                }

            }

            //part 5 two identical strings
            List<string> color = new List<string>();
            color.Add("Red");
            color.Add("Yellow");
            color.Add("Red");
            color.Add("Blue");
            color.Add("Black");
            bool found = false;
            int index = 0;

            Console.WriteLine("Please select your favorite color from the list:");
           
                string userColor = Console.ReadLine();
            while (!found)
            {
                foreach (string favColor in color)
                {

                    if (favColor == userColor)

                    {
                        Console.WriteLine("The index of your favorite color is: " + index);
                        index++;
                        found = true;
                     
                    }

                }
                if (!found)
                {
                    Console.WriteLine("Please select a name from the list");
                     userColor = Console.ReadLine();
                }

            }
            
            //Part6
            List<string> names = new List<string>();
            List<string> seenBefore = new List<string>();
            names.Add("Rose");
            names.Add("Mike");
            names.Add("Ella");
            names.Add("Tom");
            names.Add("Ella");
          
            foreach (string firstName in names)
            {
                if (seenBefore.Contains(firstName))
                {
                    Console.WriteLine(firstName + " REPEATED");
                }
                else
                {
                    Console.WriteLine(firstName + " NOT REPEATED");

                }
                seenBefore.Add(firstName);
            }
            Console.ReadLine();
            }
            
            

        }
    }


