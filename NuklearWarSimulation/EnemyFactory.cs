using System;

namespace NuklearWarSimulation
{
    public static class EnemyFactory
    {
        public static T CreateInstance<T>(T enemy, int distance) where T : Enemy, new()
        {
            T newEnemy = new T(); 
            newEnemy.Health = enemy.Health;
            newEnemy.AttackDamage = enemy.AttackDamage;
            newEnemy.Position = distance; 
            Console.WriteLine($"Created a {newEnemy.Name} with Health: {newEnemy.Health}, Attack Damage: {newEnemy.AttackDamage}, and Position: {newEnemy.Position}");
            return newEnemy; 
        }
    }
}
