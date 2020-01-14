using System;

namespace _10.MemoryLeak2
{
    class Program
    {
        static event EventHandler memoryLeak;

        static void Main(string[] args)
        {
            int times = 0;
            while (true)
            {
                times++;
                if (times % 10000000 ==0)
                {
                    Console.WriteLine("Cleaning");
                    GC.Collect();
                }
                memoryLeak += (x, y) => { };
            }
        }
    }
}
