using System;

namespace NuklearWarSimulation
{
    public abstract class Hero : IEntity
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public bool IsAlive { get; set;}
        

        public Hero(){}
        public Hero(int health, int attackDamage)
        {
            Health = health;
            AttackDamage = attackDamage;
        }

        public void TakeDamage(int damage)
        {
            if (Health - damage <= 0)
            {
                Health = 0;
                IsAlive = false;
            }
            else
            {
                Health -= damage;
            }
        }
    }
}
