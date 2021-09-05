using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameTwentyOne
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime dataTime = new DateTime(19995, 5, 23, 8,32,45);
            DateTime yearOfGraduation = new DataTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation - yearOfBirth;
            
            string text = "Here is some text";
            File.WriteAllText(@"C:\Users\Elham\log.txt", text);
            Console.WriteLine("Welcome to the Grand Hotel and Casino.Let's start by telling me your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the Casino!");
            Console.Read();
        }
    }
}