using System;
using System.Collections.Generic;

namespace NuklearWarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
    
        Bug originalBug = new Bug(100, 10);
        Enemy newBug = EnemyFactory.CreateInstance(originalBug, 5);
            
        }
    }
}