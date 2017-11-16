using System;

namespace FighterArena
{
    public class Fighter
    {
        public string Name { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Health { get; private set; }

        public Fighter(string name, int attack, int defense, int health)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fighter Arena!\n");

            while (true)
            {
                Fighter UserFighter = new Fighter("El Chamo", 9, 8, 6);

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
