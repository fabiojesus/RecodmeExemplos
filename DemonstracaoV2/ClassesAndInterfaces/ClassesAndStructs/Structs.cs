using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs
{
    //De acordo com a definição de struct, esta deverá ser imutável, e bastante pequena. Pegando num exemplo da posição num mapa, 
    //Este terá um X, um Y e algo nessa posição. o X e o Y não devem mudar. Muito menos o valor, por enquanto.
    public class StructTester
    {
        public static void TestStruct()
        {
            var mp = new MapPosition(1, 2, 3);
           // mp.X = 3; //não pode ser alterado, logo está correto.
        }
    }

    public struct MapPosition
    {
        public int X { get; } //sem set não pode ser alterado
        public int Y { get; } //sem set não pode ser alterado
        public object Value { get; } //sem set não pode ser alterado

        //E agora um construtor para todos os elementos
        public MapPosition(int x, int y, object value)
        {
            X = x;
            Y = y;
            Value = value;
        }

        //E claro que podemos ter mais que um construtor
        public MapPosition(int x, int y) : this(x, y, null) { }

        //Vamos testar?
    }

}
