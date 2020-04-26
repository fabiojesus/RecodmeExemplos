using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.DemonstracaoV2
{
    public class ActionsAndFuncs
    {
        public static void TestActionsAndFuncs()
        {
            //Vamos declarar uma action que recebe um nome e apresenta "Olá [nome]"
            //Vamos também declarar uma func para cada operação aritmética que receber dois numeros e realiza a operação

            Action<string> hello = (name) => Console.WriteLine($"Hi {name}");
            Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> sub = (x, y) => x - y;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> div = (x, y) => x / y;
            Func<int, int, int> rem = (x, y) => x % y;

            //Vamos agora criar uma lista de nomes e iterar sobre ela com a action hello
            var names = new List<string>() { "aa", "bb", "cc", "dd" };

            foreach(var name in names)
            {
                hello(name);
            }

            Console.WriteLine("\n\n\n\n");

            //E agora vamos criar uma lista com todas as operações criadas e iterar sobre ela com dois números
            var lst = new List<Func<int, int, int>>() { sum, sub, mul, div, rem };

            foreach(var op in lst)
            {
                Console.WriteLine(op(4, 9));
            }


            //Vamos testar?
            //E é assim que utilizamos, por agora, as actions e functions...






        }
    }
}
