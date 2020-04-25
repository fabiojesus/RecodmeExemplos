using System;

namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs.FirstIteration
{

    public class User
    {
        public string id;
        public string name;
        public int age;
        public long phone;
        public string email;
        public char gender;
    }

    public class UserManager
    {
        public static User RegisterUser()
        {

            var user = new User();

            Console.WriteLine("Name?");
            var tempName = Console.ReadLine();

            Console.WriteLine("Age?");
            var tempAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Phone number?");
            var tempPhoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Email?");
            var tempEmail = Console.ReadLine();

            Console.WriteLine("Gender?");
            var tempGender = Console.ReadLine()[0];

            if (tempName != string.Empty) user.name = tempName;
            if (tempAge > 18) user.age = tempAge;
            if (tempPhoneNumber.ToString().Length == 9) user.phone = tempPhoneNumber;
            if (tempEmail.Contains("@")) user.email = tempEmail;
            if (tempGender == 'M' || tempGender == 'F') user.gender = tempGender;
            GenerateId(user);

            return user;
        }

        private static string GenerateId(User user)
        {
            return string.Empty;
        }

        public static void UpdateName(User user)
        {
            Console.WriteLine("Name?");
            var tempName = Console.ReadLine();
            if (tempName != string.Empty) user.name = tempName;
            GenerateId(user);
        }

        public static void UpdateAge(User user)
        {
            Console.WriteLine("Age?");
            var tempAge = int.Parse(Console.ReadLine());
            if (tempAge > 18) user.age = tempAge;
            GenerateId(user);
        }

        public static void UpdatePhoneNumber(User user)
        {
            Console.WriteLine("Phone number?");
            var tempPhoneNumber = long.Parse(Console.ReadLine());
            if (tempPhoneNumber.ToString().Length == 9) user.phone = tempPhoneNumber;
            GenerateId(user);
        }

        public static void UpdateEmail(User user)
        {
            Console.WriteLine("Email?");
            var tempEmail = Console.ReadLine();
            if (tempEmail.Contains("@")) user.email = tempEmail;
            GenerateId(user);
        }

        public static void UpdateSex(User user)
        {
            Console.WriteLine("Gender?");
            var tempGender = Console.ReadLine()[0];
            if (tempGender == 'M' || tempGender == 'F') user.gender = tempGender;
            GenerateId(user);
        }
    }

}
