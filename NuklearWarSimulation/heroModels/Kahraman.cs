using System;

namespace NuklearWarSimulation
{
    public class Kahraman : Hero
    {    
        public Kahraman()
        {
            this.Name = "Kahraman";
        }
        public Kahraman(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Kahraman";
            System.Console.WriteLine("Kahraman has " + health + " health.");
            System.Console.WriteLine("Kahraman has " + attackDamage + " attack damage.");
        }
    }
}
