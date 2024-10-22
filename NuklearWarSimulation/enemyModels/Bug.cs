using System;

namespace NuklearWarSimulation
{
    public class Bug : Enemy
    {    
        public Bug()
        {
            this.Name = "Bug";
        }
        public Bug(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Bug";
        }
    }
}
