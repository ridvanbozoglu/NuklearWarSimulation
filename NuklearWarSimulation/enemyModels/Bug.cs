using System;

namespace NuklearWarSimulation
{
    public class Bug : Enemy
    {    
        public Bug()
        {
            this.Name = "Bug";
            System.Console.WriteLine(Name + " enemy.");
        }
        public Bug(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Bug";
            System.Console.WriteLine(Name + " has " + health + " health.");
            System.Console.WriteLine(Name + " has " + attackDamage + " attack damage.");
        }
    }
}
