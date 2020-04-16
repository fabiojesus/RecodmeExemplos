using System;

namespace ConsoleApp
{
    #region


    public class Pascaleira
    {
        static void Factorial(int num, int total = 1)
        {
            if (num == 1) Console.WriteLine($"1 = {total}");
            else
            {
                Console.Write($"{num} x ");
                total *= num;
                num--;
                Factorial(num, total);
            }
        }
        public static void ParesEntreAeB(int a, int b)
        {
            if (a % 2 == 0) Console.WriteLine(a);
            if (a < b) ParesEntreAeB((a + 1), b);
        }

        private static int Soma(int valorA, int valorB)
        {
            return valorA + valorB;
        }

        private static int Produto(int valorA, int valorB)
        {
            return valorA * valorB;
        }

        private static double Divisao(int valorA, int valorB)
        {
            try
            {
                return ((double)valorA / valorB);
            }
            catch (DivideByZeroException)
            {
                if (valorA == 0) Console.WriteLine("0 foi dividido por 0");
                else Console.WriteLine("Ocorreu uma divisão por 0.");
                return 0.0;
            }
        }

        private static void ApresentarSomaProdutoOutput(int valorA, int valorB, int soma, int produto)
        {
            Console.WriteLine($"Com os valores {valorA} e {valorB}, a soma é {soma} e o produto é {produto}");
        }

        private static void ApresentarSomaDivisaoOutput(int valorA, int valorB, int soma, double div)
        {
            Console.WriteLine($"Com os valores {valorA} e {valorB}, a soma é {soma} e a divisão é {string.Format("{0:N2}", div)}");
        }

        public static void ApresentarSomaEMultiplicação(int valorA, int valorB)
        {
            var soma = Soma(valorA, valorB);
            var prod = Produto(valorA, valorB);
            ApresentarSomaProdutoOutput(valorA, valorB, soma, prod);
        }

        public static void ApresentarSomaEDivisao(int valorA, int valorB)
        {
            var soma = Soma(valorA, valorB);
            var div = Divisao(valorA, valorB);
            ApresentarSomaDivisaoOutput(valorA, valorB, soma, div);
        }
        public static void DisplayTabuleiro(int[][] tabuleiro)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i][j] + " ");
                }
                Console.WriteLine();
            }
        }



        public static void DisplayTabuleiroRec(int[][] tabuleiro)
        {
            DisplayLinhas(tabuleiro);
        }

        public static void DisplayLinhas(int[][] tabuleiro, int count = 0)
        {
            DisplayColunas(tabuleiro[count]);
            Console.WriteLine();
            if (count < 2)
            {
                DisplayLinhas(tabuleiro, (count + 1));
            }
        }

        public static void DisplayColunas(int[] linha, int count = 0)
        {
            Console.Write(linha[count] + " ");
            if (count < 2)
            {
                DisplayColunas(linha, (count + 1));
            }
        }



        public static void PrimeirosNumerosNaturais(int limit, int counter = 1)
        {
            Console.WriteLine(counter);
            if (counter < limit)
            {
                PrimeirosNumerosNaturais(limit, (counter + 1));
            }
        }

    }
    #endregion


    class Program
    {
        private static int RequestNumber()
        {
            Console.WriteLine("Número?");
            return int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int a = RequestNumber();
            Console.Write($"{a}! = ");
            Factorial(a);
            //int total = 1;
            //Console.Write($"{a}! = ");
            //while(a > 1)
            //{
            //    Console.Write($"{a} x ");
            //    total *= a;
            //    a--;
            //}
            //Console.WriteLine($"1 = {total}");
        }

  

        
    }
}
