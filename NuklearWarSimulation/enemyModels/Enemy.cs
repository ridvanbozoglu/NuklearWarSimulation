using System;

namespace NuklearWarSimulation
{
    public abstract class Enemy : IEntity
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public bool IsAlive { get; set;}
        

        public Enemy(){}
        public Enemy(int health, int attackDamage)
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
