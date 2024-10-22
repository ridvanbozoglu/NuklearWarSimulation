using System;

namespace NuklearWarSimulation
{
    public class Lion : Enemy
    {    
        public Lion()
        {
            this.Name = "Lion";
            System.Console.WriteLine(Name + " enemy.");
        }
        public Lion(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Lion";
            System.Console.WriteLine(Name + " has " + health + " health.");
            System.Console.WriteLine(Name + " has " + attackDamage + " attack damage.");
        }
    }
}
