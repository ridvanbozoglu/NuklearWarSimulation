using System;

namespace NuklearWarSimulation
{
    public abstract class Enemy : IEntity
    {   
        public int _health;
        public int _attackDamage;

        public string Name { get; set; }
        public int Position { get; set; }
        public int Health 
        { 
            get
            { 
                return _health; 
            }
            set
            {
                System.Console.WriteLine(Name +" has " + value + " health.");
                _health = value;
            }
        }
        public int AttackDamage 
        { 
            get
            { 
                return _attackDamage; 
            } 
            set
            {
                System.Console.WriteLine(Name +" has " + value + " attack damage.");
                _attackDamage = value;
            }
        }
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
