using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Para demonstrar as capacidades do LINQ, vamos primeiro criar uma classe. Chama-se dog e vai conter dados acerca do nome, raça, idade e quantidade 
//de pulgas.
namespace Recodme.Formacao.DemonstracaoV2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Fleas { get; set; }
    }
    //Já temos a nossa classe. Vamos testar algumas funcionalidades do link numa lista de "Dog"

    public static class LinqTester
    {
        public static void TestLinq()
        {
            //vamos criar uma lista e inserir alguns dados...
            var dogs = new List<Dog>();
            dogs.Add(new Dog() { Age = 3, Fleas = 3,  Name = "Rex",         Breed = "Shiba"});
            dogs.Add(new Dog() { Age = 9, Fleas = 2,  Name = "Charlie",     Breed = "German Shepherd"});
            dogs.Add(new Dog() { Age = 3, Fleas = 20, Name = "Noodles",     Breed = "Shiba"});
            dogs.Add(new Dog() { Age = 9, Fleas = 8,  Name = "Fernando",    Breed = "Labradoodle"});
            dogs.Add(new Dog() { Age = 8, Fleas = 0,  Name = "Bobby",       Breed = "Shiba"});
            dogs.Add(new Dog() { Age = 9, Fleas = 5,  Name = "Max",         Breed = "Cão de Àgua"});
            dogs.Add(new Dog() { Age = 2, Fleas = 0,  Name = "Min",         Breed = "Shiba"});
            dogs.Add(new Dog() { Age = 9, Fleas = 21, Name = "Average",     Breed = "Pastor Austraianao"});
            dogs.Add(new Dog() { Age = 9, Fleas = 0,  Name = "Scooby",      Breed = "Shiba"});
            dogs.Add(new Dog() { Age = 9, Fleas = 5,  Name = "Snoopy",      Breed = "Bulldog francês"});
            dogs.Add(new Dog() { Age = 9, Fleas = 30, Name = "Abilio",      Breed = "Can Turner"});
            dogs.Add(new Dog() { Age = 9, Fleas = 2,  Name = "Adele",       Breed = "Boxer"});
            dogs.Add(new Dog() { Age = 3, Fleas = 0,  Name = "Soraia",      Breed = "Boxer"});
            dogs.Add(new Dog() { Age = 3, Fleas = 0,  Name = "Kyra",        Breed = "Boxer"});

            //Agora que temos a nossa lista vamos querer realizar uma série de pesquisas e operações, sendo estas:
            //1. Listar os Boxers que não têm pulgas
            var boxersWithoutFleas = dogs.Where(dog => dog.Fleas == 0 && dog.Breed == "Boxer");
            //isto é o equivalente a
            var boxersWithoutFleasNoLinq = new List<Dog>();
            foreach(var dog in dogs)
            {
                //repara que a variável dog no Where tem o mesmo efeito que no foreach (são ambas criadas a cada iteração)
                if(dog.Fleas == 0 && dog.Breed == "Boxer")
                {
                    boxersWithoutFleasNoLinq.Add(dog);
                }
            }
            //Como podem ver, com linq é bem menos código... Claro que demora um pouco a habituar.

            //2. Listar os Boxers que não têm pulgas (com from...where)

            boxersWithoutFleas = from dog in dogs where dog.Breed == "Boxer" && dog.Fleas == 0 select dog;

            //É exatamente o mesmo para o caso anterior. Pode ser representado através de um foreach


            //3. Da lista de Boxers, obter o primeiro

            var firstBoxerWithNoFleas = boxersWithoutFleas.FirstOrDefault(); //O default é utilizado para caso não exista, retornar null;
            
            //4. Da lista de Boxers, obter o primeiro com a idade > 2

            firstBoxerWithNoFleas = boxersWithoutFleas.FirstOrDefault(dog => dog.Age > 2); //O default é utilizado para caso não exista, retornar null;

            //5. Da lista de Boxers, obter o primeiro com a idade > 10
            firstBoxerWithNoFleas = boxersWithoutFleas.FirstOrDefault(dog => dog.Age > 10); //O default é utilizado para caso não exista, retornar null;

            //6. Apresentar uma lista com os nomes dos boxers sem pulgas
            var names = boxersWithoutFleas.Select(dog => dog.Name);

            //7. Iterar a lista

            foreach(var dog in dogs)
            {
                Console.WriteLine(dog.Age);
            }

            //8. Contar o número de cães sem pulgas
            var dogsWithNoFleas = dogs.Count(dog => dog.Fleas == 0);
            //9. Desparasitar todos os cães com pulgas

            foreach(var dog in dogs)
            {
                dog.Fleas = 0;
            }

            //Vamos testar?
        }
    }
}
