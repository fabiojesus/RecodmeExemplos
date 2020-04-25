using System;

namespace Recodme.Formacao.Demos.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs
{
    #region Start
    //Se observarmos esta classe, reparamos que existem demasiados argumentos, e existe também uma constante dependencia destes para gerar o id. Logo,
    //Não só existe a necessidade de inserir todos os argumentos em qualquer update, mas também estamos sugeitos a problemas de nomes de variáveis ao copiar código.
    //Como é que conseguimos resolver esta complexidade?
    public class UserManager_Functional
    {

        private static string GenerateId(string name, int age, long phoneNumber, string email, char gender)
        {
            return string.Empty;
        }

        public static string RegisterUser(ref string name, ref int age, ref long phoneNumber, ref string email, ref char gender)
        {
            Console.WriteLine("Name?");
            var tempName = Console.ReadLine();
            

            Console.WriteLine("Age?");
            var tempAge = int.Parse(Console.ReadLine());
            if (tempAge > 0)
            {
                age = tempAge;
            }


            Console.WriteLine("Phone number?");
            var tempPhoneNumber = long.Parse(Console.ReadLine());
            if (tempPhoneNumber.ToString().Length != 9)
            {
                phoneNumber = tempPhoneNumber;
            }

            Console.WriteLine("Email?");
            var tempEmail = Console.ReadLine();
            if (tempEmail.Contains("@"))
            {
                email = tempEmail;
            }


            Console.WriteLine("Gender?");
            var tempGender = Console.ReadLine()[0];
            if(tempGender == 'M' || tempGender == 'F')
            {
                gender = tempGender;
            }

            return GenerateId(name, age, phoneNumber, email, gender);
        }

        public static void UpdateName(ref string id, ref string name, ref int age, ref long phoneNumber, ref string email, ref char gender)
        {
            Console.WriteLine("Name?");
            var tempName = Console.ReadLine();
            if (tempName != string.Empty)
            {
                name = tempName;
            }
            GenerateId(name, age, phoneNumber, email, gender);
        }

        public static void UpdateEmail(ref string id, ref string name, ref int age, ref long phoneNumber, ref string email, ref char gender)
        {
            Console.WriteLine("Email?");
            var tempEmail = Console.ReadLine();
            if (tempEmail.Contains("@"))
            {
                email = tempEmail;
            }
            GenerateId(name, age, phoneNumber, email, gender);
        }

        public static void UpdateAge(ref string id, ref string name, ref int age, ref long phoneNumber, ref string email, ref char gender)
        {
            
            Console.WriteLine("Phone number?");
            var tempPhoneNumber = long.Parse(Console.ReadLine());
            if (tempPhoneNumber.ToString().Length != 9)
            {
                phoneNumber = tempPhoneNumber;
            }
            GenerateId(name, age, phoneNumber, email, gender);
        }

        public static void UpdatePhoneNumber(ref string id, ref string name, ref int age, ref long phoneNumber, ref string email, ref char gender)
        {
            Console.WriteLine("Age?");
            var tempAge = int.Parse(Console.ReadLine());
            if (tempAge > 0)
            {
                age = tempAge;
            }
            GenerateId(name, age, phoneNumber, email, gender);
        }

        public static void UpdateSex(ref string id, ref string name, ref int age, ref long phoneNumber, ref string email, ref char sex)
        {
            Console.WriteLine("Sex?");
            var tempSex = Console.ReadLine()[0];
            if (tempSex == 'M' || tempSex == 'F')
            {
                sex = tempSex;
            }
            GenerateId(name, age, phoneNumber, email, sex);
        }
    }
    #endregion

}
