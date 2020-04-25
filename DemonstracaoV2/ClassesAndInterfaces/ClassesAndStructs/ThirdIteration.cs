using System;
using System.Collections.Generic;
using System.Text;

//Nesta terceira iteração, iremos utilizar algum açucar sintático, e adicionar um construtor
namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs.ThirdIteration
{
    public enum Gender
    {
        None,
        Male,
        Female
    }

    //No User, começamos por substituir os getters e setters por acessores. O uso de um acessor é bastante simples. Vamos adicionar uma propriedade extra para demonstrar.
    //Como address aceita qualquer valor, não requer qualquer tipo de validação, logo podemos utilizar os acessores normais.
    //No entanto, as outras propriedades requerem validação no set...
    public class User
    {
        private void GenerateId()
        {
            Id = string.Empty;
        }

        //O id pode ser alterado apenas no generate. Logo, para evitarmos alterações, metemos o set a private
        public string Id { get; private set; }

        public string Address { get; set; }


        //Todas as outras têm validação, e existem algumas que não são alteradas...

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //o valor de argumento para o set tem sempre o nome "value". Agora já não precisamos do this!
                if (value != string.Empty)
                    name = value;
                GenerateId();
            }
        }


        private DateTime birthDate;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (DateTime.Now.Year - value.Year > 18)
                    birthDate = value;
                GenerateId();
            }
        }

        private long phone;

        public long Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value.ToString().Length == 9)
                    phone = value;
                GenerateId();
            }
        }


        private Gender gender;

        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != Gender.None)
                    gender = value;
                GenerateId();
            }
        }
        

        private string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@"))
                    email = value;
                GenerateId();
            }
        }

        private int regionCode;

        public int RegionCode
        {
            get
            {
                return regionCode;
            }
            set
            {
                if (value > 99 && value < 1000)
                    regionCode = value;
                GenerateId();
            }
        }
        //Resta apenas um valor que não pode ser alterado (combo telefone + codigo

        public string CompletePhoneNumber
        {
            get
            {
                return $"+{regionCode} {phone}";
            }
        }

        //E termina aqui a classe User... E o manager?
    }

    public class UserManager
    {
        public static User RegisterUser()
        {

            var user = new User();

            Console.WriteLine("Name?");
            user.Name=Console.ReadLine();

            Console.WriteLine("Birthday?");
            user.BirthDate=DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Phone number?");
            user.Phone=long.Parse(Console.ReadLine());

            Console.WriteLine("Email?");
            user.Email=Console.ReadLine();

            Console.WriteLine("Region Code?");
            user.RegionCode=int.Parse(Console.ReadLine());

            Console.WriteLine("Gender? M/F");
            switch (Console.ReadLine())
            {
                case "M": user.Gender=Gender.Male; break;
                case "F": user.Gender=Gender.Female; break;

            }

            return user;
        }

        //E os updates também

        public static void UpdateName(User user)
        {
            Console.WriteLine("Name?");
            user.Name=Console.ReadLine();
        }

        public static void UpdateAge(User user)
        {
            Console.WriteLine("Birthday?");
            user.BirthDate=DateTime.Parse(Console.ReadLine());
        }

        public static void UpdatePhoneNumber(User user)
        {
            Console.WriteLine("Phone number?");
            user.Phone=long.Parse(Console.ReadLine());
        }

        public static void UpdateRegionCode(User user)
        {
            Console.WriteLine("Region Code?");
            user.RegionCode=int.Parse(Console.ReadLine());
        }

        public static void UpdateEmail(User user)
        {
            Console.WriteLine("Email?");
            user.Email=Console.ReadLine();
        }

        public static void UpdateGender(User user)
        {
            Console.WriteLine("Gender? M/F");
            switch (Console.ReadLine())
            {
                case "M": user.Gender=Gender.Male; break;
                case "F": user.Gender=Gender.Female; break;

            }
        }
        //E agora, está bom?
        //Estar até está, mas e se fossemos ao próximo nível de açucar sintático?
    }
}