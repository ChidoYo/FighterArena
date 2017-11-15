using System;
using System.Collections.Generic;
using System.Text;
using FighterArena.Core.Interfaces;

namespace FighterArena.Core.Services
{
    public class ConsoleFighterCreator : IFighterCreator
    {
        public FighterBase Create()
        {
            var health = 0;
            var defense = 0;
            var attack = 0;
            var name = String.Empty;
            Console.WriteLine("Enter your fighter's name...");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter your fighter's Attack level... (1 to 10)");
            attack = CollectInt(1, 10);

            Console.WriteLine("\nEnter your fighter's Defense level... (1 to 10)");
            defense = CollectInt(1, 10);

            Console.WriteLine("\nEnter your fighter's Health level... (1 to 10)");
            health = CollectInt(1, 10);
            return new FighterBase(name,attack,defense,health);
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
