using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs.SecondIteration
{
    //a segunda iteração passa por tomar em consideração os tipos das propriedades da classe, e quais as propriedades que devem ser alteradas
    //devemos também neste passo adicionar métodos de alteração e obtenção de dados
    //Os getters e setters são colocados por três motivos
    //1- pode ser necessário restringir a alteração de certos dados
    //2- pode ser necessário validar a alteração de certos dados
    //3- pode ser necessário formatar dados antes de os apresentar




    //Vamos começar
    //1- Idade? e daqui a um ano? continua com a mesma?
    //2- Género. Existem dois. Porque não limitar a escolha num enum?
    //3 - O telefone pode ser composto por um código de região

    //os enums têm por defeito o primeiro valor, por isso vamos colocar None.
    public enum Gender
    {
        None,
        Male,
        Female
    }

    //Vamos adicionar os getters e setters
    //Agora vamos colocar as propriedades privadas...
    //E temos finalmente a nossa classe user pronta. Mas será o suficiente? Em grande parte das linguagens sim, mas em C# podemos avançar ainda mais.
    public class User
    {
        //Já que o temos, não precisamos de ter o setId publico
        private void GenerateId()
        {
            SetId(string.Empty);
            
        }
        
        private string id;
        public string GetId()
        {
            return id;
        }
        
        //O método não sabe qual é o id do argumento e o da classe. Devemos utilizar o this. para identificar o da classe
        private void SetId(string id)
        {
            this.id = id;
        }

        //Agora que adicionamos o primeiro getter e setter, os outros são iguais
        //e podemos também colocar nos setters as validações
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if (name != string.Empty) 
                this.name = name;
            GenerateId();
        }

        private DateTime birthDate;

        public DateTime GetBirthDate()
        {
            return birthDate;
        }
        //Por agora é o suficiente, mas uma data de nascimento deveria ser validada ao minuto...
        public void SetBirthDate(DateTime birthDate)
        {
            if (DateTime.Now.Year - birthDate.Year > 18)
            this.birthDate = birthDate;
            GenerateId();
        }

        private long phone;
        
        public long GetPhone()
        {
            return phone;
        }

        public void SetPhone(long phone)
        {
            if (phone.ToString().Length == 9)
            this.phone = phone;
            GenerateId();
        }


        private Gender gender;
    
        public Gender GetGender()
        {
            return gender;
        }

        //A validação do género é feita através de poder inserir todos os generos menos None
        public void SetGender(Gender gender)
        {
            if(gender != Gender.None)
            this.gender = gender;
            GenerateId();
        }

        //Falta apenas o email

        private string email;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            if (email.Contains("@"))
                this.email = email;
            GenerateId();
        }

        //Agora fazemos as alterações necessárias para permitir a adição de um código de região
        private int codigoRegiao;

        public int GetRegionCode()
        {
            return codigoRegiao;
        }

        public void SetRegionCode(int codigoRegiao)
        {
            if (codigoRegiao > 99 && codigoRegiao < 1000)
                this.codigoRegiao = codigoRegiao;
        }

        //queremos também apresentar o contacto telefonico completo

        public string GetPhoneNumberWithRegion()
        {
            return $"+{codigoRegiao} {phone}";
        }

        //resta apenas fazer as alterações  necessárias no UserManager
    }

    public class UserManager
    {
        public static User RegisterUser()
        {

            var user = new User();

            Console.WriteLine("Name?");
            user.SetName(Console.ReadLine());

            Console.WriteLine("Birthday?");
            user.SetBirthDate(DateTime.Parse(Console.ReadLine()));

            Console.WriteLine("Phone number?");
            user.SetPhone(long.Parse(Console.ReadLine()));

            Console.WriteLine("Email?");
            user.SetEmail(Console.ReadLine());

            Console.WriteLine("Region Code?");
            user.SetRegionCode(int.Parse(Console.ReadLine()));

            Console.WriteLine("Gender? M/F");
            switch (Console.ReadLine())
            {
                case "M": user.SetGender(Gender.Male);break;
                case "F": user.SetGender(Gender.Female);break;

            }
            return user;
        }


        //Se o generate id ocorre em todos os updates, porque não executá-lo como algo proprio da classe?

        public static void UpdateName(User user)
        {
            Console.WriteLine("Name?");
            user.SetName(Console.ReadLine());
        }

        public static void UpdateAge(User user)
        {
            Console.WriteLine("Birthday?");
            user.SetBirthDate(DateTime.Parse(Console.ReadLine()));
        }

        public static void UpdatePhoneNumber(User user)
        {
            Console.WriteLine("Phone number?");
            user.SetPhone(long.Parse(Console.ReadLine()));
        }

        //Mesmo assim, nomes trocados podem continuar a acontecer...
        public static void UpdateRegionCode(User user)
        {
            Console.WriteLine("Region Code?");
            user.SetRegionCode(int.Parse(Console.ReadLine()));
        }

        public static void UpdateEmail(User user)
        {
            Console.WriteLine("Email?");
            user.SetEmail(Console.ReadLine());
        }

        //O nome não está correto.
        public static void UpdateGender(User user)
        {
            Console.WriteLine("Gender? M/F");
            switch (Console.ReadLine())
            {
                case "M": user.SetGender(Gender.Male); break;
                case "F": user.SetGender(Gender.Female); break;

            }
        }
    }
}
