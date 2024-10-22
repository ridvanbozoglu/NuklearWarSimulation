using System;


namespace NuklearWarSimulation
{
    interface IEntity
    {
        int Health { get; set; }
        int AttackDamage { get; set; }
        bool IsAlive { get; set;}
        void TakeDamage(int damage);
    }
}
