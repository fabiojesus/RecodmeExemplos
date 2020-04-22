using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DemonstracaoV1
{
    public class Strings
    {
        #region Strings como Arrays
        public void ObterCaracterNumaString()
        {
            var text = "abcd";
            var first = text[0];
        }

        public void AlterarCaracterNumaString()
        {
            var text = "abcd";
            //text[0] = 'u';
        }

        public static string SecondHalfSetence(string text)
        {
            //dividir uma frase ao meio (arredonda o resto para cima)
            var half = (double)text.Length / 2;
            var halfPosition = (int)Math.Floor(half);
            var remainder = (int)Math.Ceiling(half);
            if (halfPosition + remainder > text.Length) remainder--;
            else if (halfPosition + remainder < text.Length) remainder++;
            return text.Substring(halfPosition, remainder);
        }

        #endregion

        #region Reverse 
        public static string InvertString(string text)
        {
            var result = string.Empty;

            foreach (var @char in text)
            {
                result = @char + result;
            }

            return result;
        }
        #endregion

        #region Most Used Character with array
        /// <summary>
        /// Retorna o caracter mais utilizado numa frase. Caso existam caracteres com o mesmo número de usos, retorna o primeiro.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static char MostUsedCharacter(string text)
        {
            var result = '\0';
            //Primeiro, decidir como estruturar o problema. É bastante util ter uma lista de caracteres no texto.
            //Já temos os caracteres
            var chars = CharactersInText(text);
            //agora precisamos da contagem de repetidos...
            var counts = GetCharacterCount(text, chars);

            //Agora que temos a contagem, é necessário determinar o máximo.

            int max = 0;
            int maxPos = 0; //A posição onde o máximo se encontra
            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > max)
                {
                    max = counts[i];
                    maxPos = i;
                }
            }

            //agora que temos a posição do caracter que se repete mais vezes, basta retornar o caracter nessa posição

            result = chars[maxPos];

            return result;

        }

        public static int[] GetCharacterCount(string text, char[] availableCharacters)
        {
            var count = new int[availableCharacters.Length];
            foreach (var @char in text)
            {
                for (var i = 0; i < availableCharacters.Length; i++)
                {
                    //verificamos a posição do caracter @char e colocamos uma unidade nessa posição do array count...
                    if (@char == availableCharacters[i])
                    {
                        count[i]++;
                        break;
                    }
                }
            }
            return count;
        }


        public static char[] CharactersInText(string text)
        {
            var chars = new char[text.Length];
            //o array terá no máximo tantos caracteres quanto os que existirem na string
            var lastPosition = 0;
            //precisamos também de obter sempre a mesma posição do ultimo caracter inserido...

            foreach (var @char in text)
            {
                var found = false;
                for (var i = 0; i < lastPosition; i++)
                {
                    //assim só vai até ao ultimo caracter inserido...
                    if (@char == chars[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    chars[lastPosition] = @char;
                    lastPosition++;
                    //Prenchemos o ultimo espaço vazio e passamos para o próximo.
                }
            }

            //E terminou por aqui. Mas, e se existirem espaços que não foram ocupados?

            var result = new char[lastPosition];
            for (var i = 0; i < lastPosition; i++)
            {
                result[i] = chars[i];
            }
            return result;
        }
        #endregion

        #region Most Used Character with dictionary
        public static char MostUsedCharacterWithDict(string text)
        {
            var result = '\0';
            var dict = new Dictionary<char, int>();
            foreach(var @char in text)
            {
                if (!dict.ContainsKey(@char)) dict.Add(@char, 0);
                dict[@char]++;
            }
            var max = 0;
            foreach(var item in dict)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }
            return result;
        }
        #endregion

        #region Funcionalidades do tipo String
        public static string[] WordsInASetence(string text)
        {
            return text.Split(" ");
        }

        public static bool DoesItHaveTuna(string text)
        {
            return text.Contains("Tuna", StringComparison.OrdinalIgnoreCase);
        }

        public static string AskedForSalmonGotTuna(string text)
        {
            return text.Replace("Tuna", "Salmon");
        }

        public static void YellAtWaiter(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        public static string ClearSpaces(string text)
        {
            return text.Trim();
        }
        #endregion

    }
}
