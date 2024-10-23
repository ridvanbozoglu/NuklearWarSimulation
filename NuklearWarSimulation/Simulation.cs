using System;
using System.Linq;
using System.Collections.Generic;

namespace NuklearWarSimulation
{
    public static class Simulation
    {    
        public static void Simulate(Hero hero, List<Enemy> enemies, int distance)
        {
            System.Console.WriteLine(hero.Name + " started the journey with " + hero.Health + " health!");

            List<Enemy> sortedEnemies = enemies.OrderBy(e => e.Position).ToList();
            List<Enemy> possibleEnemies = sortedEnemies
                .Where(e => isInDistance(e, distance))
                .ToList();

            Queue<Enemy> enemyQueue = new Queue<Enemy>(possibleEnemies);

            while (enemyQueue.Count > 0)
            { 
                Enemy enemy = enemyQueue.Dequeue();
                hero.Position = enemy.Position;

                int AttackNeededToKillEnemy = (int)Math.Ceiling((double)enemy.Health / hero.AttackDamage);
                int AttackNeededToKillHero = (int)Math.Ceiling((double)hero.Health / enemy.AttackDamage);

                int AttackPerformed = Math.Min(AttackNeededToKillEnemy, AttackNeededToKillHero);

                if (AttackNeededToKillEnemy < AttackNeededToKillHero)
                {
                    enemy.Health = 0;
                    enemy.IsAlive = false;
                    hero.Health -= AttackPerformed * enemy.AttackDamage;

                    System.Console.WriteLine(hero.Name + ", killed " + enemy.Name + " with " + hero.Health + " health.");
                }
                else
                {
                    hero.Health = 0;
                    hero.IsAlive = false;
                    enemy.Health -= AttackPerformed * hero.AttackDamage;

                    System.Console.WriteLine(hero.Name + ", killed. Last seen at " + hero.Position + " meters!");
                    return;
                }
            }

            System.Console.WriteLine(hero.Name + " survived the journey!");
        }

        static bool isInDistance(Enemy enemy, int distance)
        {
            if (enemy.Position > distance)
            {
                System.Console.WriteLine(enemy.Name + " is too far!");
                return false;
            }
            return true;
        }
    }
}
