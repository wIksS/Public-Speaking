using System;
using System.Threading;

namespace GargbageCollection
{
    class User
    {
        ~User()
        {
            Console.WriteLine("I was destroyed");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var weakRef = Test();
            Console.WriteLine(weakRef.IsAlive);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine(weakRef.IsAlive);
        }

        static WeakReference Test()
        {
            var p = new User();
            return new WeakReference(p);
        }
    }
}
