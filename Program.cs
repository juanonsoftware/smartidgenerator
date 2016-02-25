using GdNet.Common.IdGenerators;
using System;
using System.IO;
using System.Text;

namespace UniqueNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var g1 = new TimebaseHexIdGenerator();
            var g2 = new SlimHexIdGenerator();
            var g3 = new ShortHexIdGenerator();
            var g4 = new SupperShortIdGenerator(IdBase.Duosexagesimal);

            var t1 = DateTime.Now;
            var sb = new StringBuilder();
            var count1 = 0;

            while ((DateTime.Now - t1).Seconds < 1)
            {
                sb.AppendLine(g1.NewId());
                count1 += 1;
            }
            File.WriteAllText("TimebaseHexIdGenerator.txt", sb.ToString());
            sb.Clear();

            t1 = DateTime.Now;
            var count2 = 0;
            while ((DateTime.Now - t1).Seconds < 1)
            {
                sb.AppendLine(g2.NewId());
                count2 += 1;
            }
            File.WriteAllText("SlimHexIdGenerator.txt", sb.ToString());
            sb.Clear();

            t1 = DateTime.Now;
            var count3 = 0;
            while ((DateTime.Now - t1).Seconds < 1)
            {
                sb.AppendLine(g3.NewId());
                count3 += 1;
            }
            File.WriteAllText("ShortHexIdGenerator.txt", sb.ToString());
            sb.Clear();

            t1 = DateTime.Now;
            var count4 = 0;
            while ((DateTime.Now - t1).Seconds < 1)
            {
                sb.AppendLine(g4.NewId());
                count4 += 1;
            }
            File.WriteAllText("SupperShortIdGenerator.txt", sb.ToString());
            sb.Clear();

            t1 = DateTime.Now;
            var count5 = 0;
            while ((DateTime.Now - t1).Seconds < 1)
            {
                sb.AppendLine(Guid.NewGuid().ToString());
                count5 += 1;
            }
            //File.WriteAllText("Guid.txt", sb.ToString());
            sb.Clear();

            Console.WriteLine("TimebaseHexIdGenerator: " + count1);
            Console.WriteLine("SlimHexIdGenerator: " + count2);
            Console.WriteLine("ShortHexIdGenerator: " + count3);
            Console.WriteLine("SupperShortIdGenerator: " + count4);
            Console.WriteLine("Guid: " + count5);
            Console.ReadLine();
        }
    }
}
