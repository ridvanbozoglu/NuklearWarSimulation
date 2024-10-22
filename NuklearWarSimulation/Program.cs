using System;
using System.Collections.Generic;

namespace NuklearWarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = 60;
            System.Console.WriteLine("Resources " + distance + "  meters away.");
            Hero hero = new Kahraman(100,3);
            Bug originalBug = new Bug();
            originalBug.Health = 100;
            originalBug.AttackDamage = 3;
            
            List<Enemy> enemies = new List<Enemy>
            {
                EnemyFactory.CreateInstance(originalBug, 5),
                EnemyFactory.CreateInstance(originalBug, 50),
                EnemyFactory.CreateInstance(originalBug, 25)
            };
            Simulation.Simulate(hero, enemies, 60);
            
        }
    }
}