using System;
using System.Collections.Generic;
using System.Text;

namespace DemonstracaoV1
{
    public class Dates
    {
        public static void DateExamples()
        {
            DateTime date = new DateTime(1990, 08, 29);
            DateTime currentDate = DateTime.UtcNow;
            date = date.AddDays(1);
            date = date.AddHours(1);

            //Subtração

            date = date.AddDays(-1);

            //formatação
            Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
