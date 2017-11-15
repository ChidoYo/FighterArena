using FighterArena.Core;
using System;
using System.Runtime.CompilerServices;

namespace FighterArena
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fighter Arena!\n");
            var health = 0;
            var defense = 0;
            var attack = 0;
            var name = String.Empty;
            while (true)
            {
           
                Console.WriteLine("Enter your fighter's name...");
                name = Console.ReadLine();

                Console.WriteLine("\nEnter your fighter's Attack level... (1 to 10)");
                attack = CollectInt(1,10);

                Console.WriteLine("\nEnter your fighter's Defense level... (1 to 10)");
                defense = CollectInt(1, 10);

                Console.WriteLine("\nEnter your fighter's Health level... (1 to 10)");
                health = CollectInt(1, 10);

                var fighter = new FighterBase(name, attack, defense, health);
                Console.WriteLine(fighter.ToString());

                Console.WriteLine("\nQuit? Y / Q");
                string response = Console.ReadLine();

                if (response.ToLower() == "y" || response.ToLower() == "q")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }


        }

        private static int CollectInt(int min, int max)
        {
            var valid = false;
            int value = min - 1;
            while (!valid)
            {
                if (!int.TryParse(Console.ReadLine(), out value) || value > max || value < min)
                {
                    Console.WriteLine("invalid number, please try again.  Must be between {0} and {1}", min, max);
                }
                else
                {
                    valid = true;
                }
            }
            return value;
        }
    }
}
