using System;
namespace MathSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MathSharp Sample";
            Vector testVectior = new Vector(_x:3,_y:4);
            Vector testVectiorB = new Vector(_x:6,_y:8);
            Vector Vec = new Vector(1,1);
            WorldController worldController = new WorldController();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Get distance method test:" + Vector.GetDistancefromTwoVectors(testVectior,testVectiorB));
        }
    }
}