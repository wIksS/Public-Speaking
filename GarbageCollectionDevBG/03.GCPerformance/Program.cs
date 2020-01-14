using System;
using System.Diagnostics;
using System.Threading;

namespace _03.GCPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 100000;
            User user = null;
            Stopwatch watch = Stopwatch.StartNew();
            //var users = new User[times];
            //for (int i = 0; i < times; i++)
            //{
            //    users[i] = new User();
            //}

            //watch.Stop();
            //Console.WriteLine("Without Garbage Collection");
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //watch.Reset();
            //watch.Start();
            for (int i = 0; i < times; i++)
            {
                user = new User();
            }

            watch.Stop();
            Console.WriteLine("With normal Garbage collection");
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Reset();
            watch.Start();
            for (int i = 0; i < times; i++)
            {
                user = new User();
                GC.Collect();
            }

            watch.Stop();
            Console.WriteLine("With Garbage Collection on each cycle");
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }

    class User { }
}
