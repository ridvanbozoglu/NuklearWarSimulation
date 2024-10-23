using System;
using System.Collections.Generic;

namespace NuklearWarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = 5000;
            System.Console.WriteLine("Resources " + distance + "  meters away.");

            Hero hero = new Kahraman(1000, 10);

            Bug bug = new Bug();
            Lion lion = new Lion();
            Zombi zombi = new Zombi();
            bug.Health = 50;
            bug.AttackDamage = 2;
            lion.Health = 100;
            lion.AttackDamage = 15;
            zombi.Health = 300;
            zombi.AttackDamage = 7;
            
            List<Enemy> enemies = new List<Enemy>
            {
                EnemyFactory.CreateInstance(zombi, 1681),
                EnemyFactory.CreateInstance(bug, 276),
                EnemyFactory.CreateInstance(bug, 489),
                EnemyFactory.CreateInstance(lion, 1527),
                EnemyFactory.CreateInstance(lion, 2865),
                EnemyFactory.CreateInstance(zombi, 3523),
            };

            Simulation.Simulate(hero, enemies, distance);
        }
    }
}