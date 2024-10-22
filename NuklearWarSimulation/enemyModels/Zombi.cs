using System;

namespace NuklearWarSimulation
{
    public class Zombi : Enemy
    {    
        public Zombi()
        {
            this.Name = "Zombi";
        }
        public Zombi(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Zombi";
        }
    }
}
