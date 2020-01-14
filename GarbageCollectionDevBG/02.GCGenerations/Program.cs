using System;

namespace _02.GCGenerations
{
    class Program
    {
        class User
        {
        }

        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine(GC.GetGeneration(user));

            GC.Collect();
            Console.WriteLine(GC.GetGeneration(user));
            
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(user));

            GC.Collect();
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(user));
        }
    }
}
