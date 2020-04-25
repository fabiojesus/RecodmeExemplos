using System;
using System.Collections.Generic;
using System.Text;

namespace DemonstracaoV1
{
    public class MathExamples
    {
        public static void TestMath()
        {
            Console.WriteLine(Math.Pow(2, 3)); //8
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Max(8, 23));
            Console.WriteLine(Math.Min(8, 23));
        }

        public static void TestRounding()
        {
            var ipos = 1.6;
            var ineg = -3.5;

            Console.WriteLine($"Negativo\n Floor{Math.Floor(ineg)}\nCeiling {Math.Ceiling(ineg)}\nRound {Math.Round(ineg)}\nTruncate {Math.Truncate(ineg)}");
            Console.WriteLine();
            Console.WriteLine($"Positivo\n Floor{Math.Floor(ipos)}\nCeiling {Math.Ceiling(ipos)}\nRound {Math.Round(ipos)}\nTruncate {Math.Truncate(ipos)}");


        }

    }
}
