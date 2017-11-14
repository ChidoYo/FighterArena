using System;

namespace FighterArena
{
    class Fighter
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fighter Arena!\n");

            while (true)
            {
                Fighter UserFighter = new Fighter();

                Console.WriteLine("Enter your fighter's name...");
                UserFighter.Name = Console.ReadLine();

                Console.WriteLine("\nEnter your fighter's Attack level... (1 to 10)");
                UserFighter.Attack = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter your fighter's Defense level... (1 to 10)");
                UserFighter.Defense = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter your fighter's Health level... (1 to 10)");
                UserFighter.Health = int.Parse(Console.ReadLine());

                Console.WriteLine("\nYour fighter's name is {0} \nAttack level {1} \nDefense level {2} \nHealth level {3}", 
                    UserFighter.Name, UserFighter.Attack, UserFighter.Defense, UserFighter.Health);

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
    }
}
