using System;

namespace NuklearWarSimulation
{
    public static class Simulation
    {    
        public static void Simulate(Hero hero, List<Enemy> enemies, int distance)
        {
            System.Console.WriteLine(hero.Name + "started the journey with " + distance + " healh!");
            List<Enemy> sortedEnemies = enemies.OrderBy(e => e.Position).ToList();
            // Burada loglama yapacağım düşman range de değil gibi....
            sortedEnemies.filter(e => e.Position <= distance);
            Queue<Enemy> enemyQueue = new Queue<Enemy>(sortedEnemies);
            while (enemyQueue.Count > 0)
            {
                Enemy enemy = enemyQueue.Dequeue();
                Hero.Position = enemy.Position;
                int AttackNeededToKillEnemy = Math.Ceiling(hero.Health/enemy.AttackDamage);
                int AttackNeededToKillHero = Math.Ceiling(enemy.Health/hero.AttackDamage);
                int AttackPerformed = Math.Min(AttackNeededToKillEnemy, AttackNeededToKillHero);
                if(AttackNeededToKillEnemy < AttackNeededToKillHero)
                {
                    enemy.Health = 0;
                    enemy.IsAlive = false;
                    hero.Health = AttackPerformed*enemy.AttackDamage; ;
                    System.Console.WriteLine(hero.Name + ", killed " + enemy.Name + " with " + hero.Health + " health.");
                }else
                {
                    hero.Health = 0;
                    hero.IsAlive = false;
                    enemy.Health = AttackPerformed*hero.AttackDamage;
                    System.Console.WriteLine(hero.Name + ", killed. Last seen at " + hero.Position + " meters!");
                    return;
                }
            }
            System.Console.WriteLine(hero.Name + "finished the journey with " + hero.Health + " health!");
        }
    }
}
