using FighterArena.Core;
using FighterArena.Core.Interfaces;
using FighterArena.Core.Services;
using System;
using System.Runtime.CompilerServices;

namespace FighterArena
{

    class Program
    {


        static void Main(string[] args)
        {
            //IFighterCreator creator = new ConsoleFighterCreator();
            //IFighterCreator creator = new JsonFileFighterCreator();
            IFighterCreator creator;
            Console.WriteLine("Welcome to Fighter Arena!\n");
            
            while (true)
            {
                Console.WriteLine("Console(1) or File(2)");
                var choice = CollectInt(1, 2);
                if (choice == 1)
                {
                    creator = new ConsoleFighterCreator();
                } 
                else
                {
                    creator = new JsonFileFighterCreator();
                }
              
                var fighter = creator.Create();

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
