using System;

namespace NuklearWarSimulation
{
    public class Bug : Enemy
    {     
        public Bug(int health, int attackDamage) : base(health, attackDamage)
        {
            this.Name = "Bug";
        }
        public Bug CreateInstance(int distance)
        {
            Bug newBug = new Bug(Health, AttackDamage);
            newBug.Position = distance;
            return newBug;
        }
    }
}
