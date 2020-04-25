using System;
using System.Collections.Generic;
using System.IO;

namespace DemonstracaoV2
{
    #region Pre-ExtMethod
    public class AglomeradoDeFuncoes
    {

        public static DateTime SubtractDaysFromDate(DateTime date, int days)
        {
            return date.AddDays(-1 * days);
        }

        public static bool NumberIsBetween(int number, int min, int max)
        {
            return number > min - 1 && number < max + 1;
        }

        public static void TestFunctions()
        {
            Console.WriteLine(SubtractDaysFromDate(DateTime.Now, 3));
            Console.WriteLine(NumberIsBetween(3, 1, 4));
        }
    }
    #endregion

    #region With Extension Methods
    public static class ExtensionMethods
    {
        public static bool IsBetween(this int num, int min, int max) 
        {
            return num > min - 1 && num < max + 1;
        }

        public static DateTime SubtractDays(this DateTime date, int days) 
        {
            return date.AddDays(-1 * days);
        }

        public static void TestMethods()
        {
            var date = DateTime.Now;
            date = date.SubtractDays(3);

            var num = 3;
            Console.WriteLine(num.IsBetween(1, 4));
            var a = new A();
            List<object> lista = new List<object>();
            foreach(var prop in a.GetType().GetProperties())
            {
                if (prop.Name == "B") throw new ArgumentException();
            }
        }
    }

    public class A
    {
        public string B { get; set; }
    }
    #endregion

}
