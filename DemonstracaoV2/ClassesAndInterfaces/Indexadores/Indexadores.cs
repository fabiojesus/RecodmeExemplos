using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.Indexadores
{
    //Os indexadores são bastante uteis quando queremos adicionar propriedades em runtime a um objeto. Funcionam um pouco como os objetos em JS.

    public class TestClass
    {
        //Para indexar através de um nome vamos querer um Dictionary<string, object>
        private Dictionary<string, object> _data;

        public TestClass()
        {
            _data = new Dictionary<string, object>();
        }

        //E agora recorremos ao this para implementar o indexador.

        public object this[string index]
        {
            get => _data.ContainsKey(index)/*verifica se a chave existe*/?_data[index]/*retorna a chave se existir*/:null/*ou um objeto nulo caso este não exista*/;
            set => _data[index] = value;
        }

        //Um dos problemas que um dictionary poderá ter é lançar uma exceção caso não encontre o index.
        //Vamos testar?
    }

    public class IndexTester
    {
        public static void TestIndex()
        {
            var obj = new TestClass();
            var obj2 = new TestClass();
            obj["Name"] = "Fábio";
            obj["Age"] = 30;

            Console.WriteLine($"My name is {obj["Name"]} and I'm {obj["Age"]} years old");

            //Tenham atenção que estes indices apenas existem em runtime e não são aplicados a todos os objetos

            Console.WriteLine($"My name is {obj2["Name"]} and I'm {obj2["Age"]} years old");


        }
    }
}
