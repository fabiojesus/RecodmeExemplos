using DemonstracaoV2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.DemonstracaoV2.Delegates
{
    //A declaração de um delegate ocorre no namespace:
    public delegate int MathDelegate(int x, int y);
    //Também pode ser genérico
    public delegate T GenericDelegate<T>(T x, T y);
    //E pode ter tantos tipos genéricos quantos necessário
    public delegate TR GenericDelegate<TR, TA>(TA x, TA y);

    public class DelegateTester
    {
        public static void TestDelegate()
        {
            //Reparem na assinatura do MathDelegate. (int(int,int)) significa que retorna int, e que tem como argumentos dois inteiros. 
            //Isto será expresso na forma de (x, y) que são os dois argumentos seguidos de => e da operação.
            //Caso a operação tenha mais que duas instruções, deverá ser colocada entre chavetas. Ou seja, ((x,y) => x+y)

            var sum = new MathDelegate((x, y) => x + y);
           var sumTotal = sum.Invoke(1, 2);
            sumTotal = sum(1, 2);
            //Agora com duas operações
            sum = new MathDelegate((x, y) =>
            {
                var temp = 12;
                temp *= x + y;
                return temp;
            });
            sumTotal = sum.Invoke(1, 2);
            //No entanto não podemos mudar a variável para outro delegate, mesmo que os argumentos e o tipo de retorno seja o mesmo.
            //sum = new GenericDelegate<int>((x, y) => x + y);

            //Chamar um genérico também é simples
            var newSum = new GenericDelegate<int>((x, y) => x + y);
            sumTotal = newSum(1, 2);
            var newSumPrinter = new GenericDelegate<string, int>((x, y) => (x + y).ToString());
            var sumPrint = newSumPrinter(1, 2);


            //Vamos testar?

        }


    }

}
