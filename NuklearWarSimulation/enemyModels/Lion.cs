using System;

namespace NuklearWarSimulation
{
    public class Lion : Enemy
    {    
        public Lion()
        {
            this.Name = "Lion";
        }
        public Lion(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Lion";
        }
    }
}
