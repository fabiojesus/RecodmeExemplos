using Outer.Middle.Inner;
using D = Outer.Middle.Inner.A;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;


namespace Recodme.Formacao.Demos.DemonstracaoV2.Namespaces
{
    class Nspaces
    {
        public static void Write() 
        {
            D d = new D();
            WriteLine("Hi");
        }

    }
}

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            public class A { }
        }
    }
}

//Equivalente a 

namespace Outer.Middle.Inner
{
    public class B 
    { 
        public A A { get; set; }
    }
}

namespace _Outer
{
    namespace Middle
    {

        public class B
        {
         //   public A A { get; set; }
        }
        namespace Inner
        {
            public class A { }
        }
    }
}