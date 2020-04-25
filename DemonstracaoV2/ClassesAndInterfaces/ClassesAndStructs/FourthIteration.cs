using System;
using System.Collections.Generic;
using System.Text;

//Chegámos à ultima iteração da transformação numa classe funcional
//Na ultima iteração não adicionamos o construtor por uma simples razão: vamos mudar o tipo do Id
//Tenham em conta que estas alterações não modificam a performance e são meramente cosméticas
namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs.FourthIteration
{
    public enum Gender
    {
        None,
        Male,
        Female
    }

    public class User
    {
        //Primeiro vamos ao ID. Os ids podem ser enumerados (identificados por numeros) ou unicos (têm uma identificação unica). Para um enumerado fariamos

        //public int Id { get; set; }

            //Mas o que queremos mesmo é um unico, até porque os enumerados têm de ser controlados e estes não:

        public Guid Id { get; }

        //Por agora ficamos aqui.
        //Vamos à parte cosmética...

        public string Address { get; set; }

        private string name;
        //Em propriedades que requerem validações, se as conseguirmos colocar todas numa linha... Neste caso, o set está numa linha, e o get também. Então utilizamos =>
        //em vez de chavetas e returns.
        public string Name
        {
            get => name; //é equivalente à anterior
            set => name = (value != string.Empty) ? /*condição*/ value /*validação verdadeira*/ : name /*validação falsa*/;
        }

        //Agora vamos aos outros:
        private DateTime birthDate;

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = (DateTime.Now.Year - value.Year > 18) ? value : birthDate;
        }

        private long phone;

        public long Phone
        {
            get => phone;
            set => phone = (value.ToString().Length == 9) ? value : phone; 
        }


        private Gender gender;

        public Gender Gender
        {
            get => gender;
            set => gender = (value != Gender.None) ? value : gender;
        }


        private string email;

        public string Email
        {
            get => email;
            set => email = (value.Contains("@")) ? value : email;
        }

        private int regionCode;

        public int RegionCode
        {
            get => regionCode;
            set => regionCode = (value > 99 && value < 1000) ? value : regionCode;
        }

        //E agora temos uma propriedade que tem um get especifico mas não tem um valor privado, chamado de backing field, associado. Podemos então...
        public string CompletePhoneNumber => $"+{regionCode} {phone}";

        //E temos a parte cosmética da classe terminada. Falta o construtor...

        public User(string name, string email, Gender gender, long phone, int regionCode)
        {
            //E o id?
            Id = Guid.NewGuid(); //Só isto!
            Name = name;
            Email = email;
            Gender = gender;
            Phone = phone;
            RegionCode = regionCode;
        }

        //E se só tivermos utilizadores com números portugueses? não é uma perda de tempo colocar sempre o código de região? 
        //Pois, realmente. MASS, podemos ter tantos construtores quantos quisermos, desde que, tenham argumentos diferentes.
        public User(string name, string email, Gender gender, long phone)
        {
            //não colocamos o region code, mas preenchemos dentro do construtor:
            RegionCode = 351;
            //não esquecer o id
            Id = Guid.NewGuid();
        }

        //Tenho de estar sempre a preencher todos os campos que não são introduzidos?
        //Bem, ainda não falamos sobre isto, mas há outra maneira. Já temos um construtor que coloca o id. Logo, podemos utilizá-lo. Vamos fazer um construtor para utilizadores
        //sem email:
        //Vemos que através do this, existem 2 construtores reconhecidos. O que preenche o id e o da regiao. vamos para o segundo:
        public User(string name, Gender gender, long phone) :this(name, "", gender, phone)
        {
            //E pronto, colocamos o valor do email no construtor e não precisamos de fazer mais nada.
        }

        //Vamos ao manager?
    }

    //Huuuum. Complicado. Pra já temos de refazer a função por causa do construtor, mas depois temos uma série de instruções repetidas no Register user e nos updates.
    //Vamos criar um novo método que peça um valor com base numa mensagem.

    public class UserManager
    {
        public static string RequestValue(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
            //Feito.
        }

        //Agora, substituimos todas as linhas repetidas.
        //Vamos usar o construtor com a regiao preenchida.
        public static User RegisterUser()
        {
            string name = RequestValue("Name?");
            
            Gender gender = Gender.None;
            switch(RequestValue("Gender? M/F"))
            {
                case "M": gender = Gender.Male; break;
                case "F": gender = Gender.Female; break;
            }

            long phone = long.Parse(RequestValue("Phone number?"));

            string email = RequestValue("Email?");

            DateTime birthDay = DateTime.Parse(RequestValue("Birthday?"));

            var user = new User(name, gender, phone) { BirthDate = birthDay };

            //Pera, e o birthday?
            //ups. Podemos fazer assim...
            //=) E está pronto. Faltam os updates, que são exatamente o mesmo que fizemos aqui...
            

            return user;
        }


        public static void UpdateName(User user) => user.Name = RequestValue("Name?");

        public static void UpdateAge(User user) => user.BirthDate = DateTime.Parse(RequestValue("Birthday?"));

        public static void UpdatePhoneNumber(User user) => user.Phone = long.Parse(RequestValue("Phone number?"));

        public static void UpdateRegionCode(User user) => user.RegionCode = int.Parse(RequestValue("Region code?"));

        public static void UpdateEmail(User user) => RequestValue("Email?");

        public static void UpdateGender(User user)
        {
            Console.WriteLine("Gender? M/F");
            switch (Console.ReadLine())
            {
                case "M": user.Gender = Gender.Male; break;
                case "F": user.Gender = Gender.Female; break;

            }
        }
        //E pronto!
        //Agora algumas notas finais
        //O código nunca é perfeito. Existe sempre alguma coisa a fazer, por isso, nunca desistam de fazer melhorias. Se falhar, começam de novo. Não é o fim do mundo.
        //Estas ultimas mudanças requerem prática e podem por vezes afetar a legibilidade de código para outros programadores. Não significa que é pior, mas toda a gente tem
        //a sua forma de programar. Tenham sempre isso em consideração, e apenas as usem quando têm a certeza que estão a ser aplicadas corretamente. Passo a palavra aos comportamentos.

    }
}