using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Demos.DemonstracaoV2.Namespaces
{

    public class EnumTests
    {
        public static void TestEnums()
        {
            var brownColor = Color.Brown;

            var whiteColor = (Color)0;

            //por ordem alfabetica o black seria o primeiro, mas o primeiro é white

            var redColor = (Color)0xFF0000;

            var parsedBlack = Enum.Parse(typeof(Color), "Black");
        }
    }

    public enum Color
    {
        White = 0xFFFFFF,
        Red = 0xFF0000,
        Blue = 0x0000FF,
        Brown = 0x800000,
        Black = 0x000000
    }

}
