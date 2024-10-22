using System;

namespace NuklearWarSimulation
{
    public class Zombi : Enemy
    {    
        public Zombi()
        {
            this.Name = "Zombi";
            System.Console.WriteLine(Name + " enemy.");
        }
        public Zombi(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Zombi";
            System.Console.WriteLine(Name + " has " + health + " health.");
            System.Console.WriteLine(Name + " has " + attackDamage + " attack damage.");
        }
    }
}
