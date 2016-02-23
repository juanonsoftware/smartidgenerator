using GdNet.Common.IdGenerators;
using System;

namespace UniqueNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new TimebaseHexIdGenerator(1);
            var t1 = DateTime.Now.Second;
            var count = 0;

            while (DateTime.Now.Second - t1 < 1)
            {
                Console.WriteLine(g.NewId());
                count += 1;
            }

            Console.WriteLine("Total: " + count);
            Console.ReadLine();
        }
    }
}
