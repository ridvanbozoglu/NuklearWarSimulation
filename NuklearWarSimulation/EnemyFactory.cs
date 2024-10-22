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
            Console.WriteLine($"Created a {newEnemy.Name} atPosition: {newEnemy.Position}");
            return newEnemy; 
        }
    }
}
