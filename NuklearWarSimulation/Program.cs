using System;
using System.Collections.Generic;

namespace NuklearWarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bug bug = new Bug(100, 10);
            Enemy bug1 = bug.CreateInstance(1000);
            System.Console.WriteLine(bug1.Position);
            
        }
    }




}