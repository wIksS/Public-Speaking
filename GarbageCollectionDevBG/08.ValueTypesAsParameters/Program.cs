using System;
using System.Runtime.InteropServices;

namespace CSharpInDepth
{
    class Program
    {
        public struct MyStruct
        {
            public double a, b, c, d, e, f, g, h, i, j, k, l, m,zz,mm,xx,tt,qq,zzz,ty,bye,pesho,gosho,dimitrichka;
        }

        static long topOfStack;
        static long stackSize = 1024 * 1024;

        unsafe static void Main(string[] args)
        {
            var someVar = new MyStruct();
            int someVariable = 5;
            topOfStack = (long)&someVariable;
            MyStruct x = new MyStruct();

            Recurse(x, 0);
        }

        unsafe static void Recurse(MyStruct x, int times)
        {
            long remaining;
            remaining = (topOfStack - ((long)&remaining));
            if (stackSize - remaining < 0)
            {
                Console.WriteLine(times);
                return;
            }
            Recurse(x, ++times);
        }
    }
}
