using GdNet.Common.IdGenerators;
using System;

namespace UniqueNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var g1 = new TimebaseHexIdGenerator();
            var g2 = new SlimHexIdGenerator();

            var t1 = DateTime.Now.Second;
            var count1 = 0;

            while (DateTime.Now.Second - t1 < 1)
            {
                Console.WriteLine(g1.NewId());
                count1 += 1;
            }

            t1 = DateTime.Now.Second;
            var count2 = 0;
            while (DateTime.Now.Second - t1 < 1)
            {
                Console.WriteLine(g2.NewId());
                count2 += 1;
            }

            Console.WriteLine("Total 1: " + count1);
            Console.WriteLine("Total 2: " + count2);
            Console.ReadLine();
        }
    }
}
