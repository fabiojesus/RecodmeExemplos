using System;
using System.Collections.Generic;
using System.Text;
//Já aprendemos a tratar exceções. Mas e a criá-las e lançá-las?
namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.Exceptions
{
    //Todas as exceções herdam de Exception (iremos eventualmente abordar a herança, mas assumam por enquanto que têm de meter : Exception
    public class TestException : Exception
    {
        public TestException() : base("A test exception")
        {

        }

        //Feito. Vamos testar?
    }

    public static class ExceptionTester
    {
        public static void TestException(string txt)
        {
            //caso o texto inserido seja "rebenta a bolha", deverá lançar a exceção
            if (txt == "rebenta a bolha") throw new TestException();
        }
    }
}
