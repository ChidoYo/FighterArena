using System;

namespace FighterArena.Core.Classes
{
    public class FighterBase
    {
        protected string Name { get; set; }
        protected int Attack { get; set; }
        protected int Defense { get; set; }
        protected int Health { get; set; }

        public FighterBase(string name, int attack, int defense, int health)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Health = health;
        }

        public override string ToString()
        {
            return $"{Name} \n Health: {Health} \n Attack: {Attack} \n Defense: {Defense}";
        }
    }
}
