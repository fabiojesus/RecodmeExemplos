using System;

namespace DemonstracaoV1
{
    public class Arrays
    {
        public static void ImplementarArray()
        {
            int[] array = new int[5];

            //alteração
            array[3] = 4; //agora o quarto valor é quatro

            //obtenção
            var quartoValor = array[3];


            //iteração com for
            for(var index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }

            //iteração com foreach
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
