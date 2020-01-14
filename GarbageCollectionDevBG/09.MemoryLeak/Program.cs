using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace MemoryLeak
{
    class Olympics
    {
        public static List<Runner> TryoutRunners;
    }
    class Runner
    {
        private string _fileName = "test.txt";
        private FileStream _fStream;
        public void GetStats()
        {
            FileInfo fInfo = new FileInfo(_fileName);
            _fStream = fInfo.OpenRead();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Olympics.TryoutRunners = new List<Runner>();
            int times = 0;
            while (true)
            {
                times++;
                if (times%10000 == 0)
                {
                    Console.WriteLine("Memory leaking all day long");
                }
                var runner = new Runner();
                Olympics.TryoutRunners.Add(runner);
                runner.GetStats();
            }
        }
    }
}
