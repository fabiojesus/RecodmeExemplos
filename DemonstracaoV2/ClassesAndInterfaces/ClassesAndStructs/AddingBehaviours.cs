using System;
using System.Collections.Generic;
using System.Text;

//Agora que fizemos todas as alterações a nivel da classe, estamos prontos para trabalhar a parte dos comportamentos.
//Vamos assumir, neste exemplo, que a classe user faz parte de um site de partilha de conteudo. Este conteudo tem um rácio (1 partilha permite 5 downloads (1:5))
//Precisamos de mais uma propriedade, que é o nosso rácio, e duas funções, QUE agora são métodos, para enviar e transferir conteudo. 
//Para este exemplo, vamos recorrer a uma mistura da terceira e quarta iteração onde removemos toda a parte de açucar sintático da classe.
//Vamos também limpar um pouco a classe, pois está demasiado extensa. Vamos assumir por agora que não existem validações.
//Muito melhor.
//Queremos também que o rácio comece a 1, para permitir que façamos 5 downloads. Quando o rácio atinge 0 não podemos fazer downloads. Não existe limite para uploads, 
//mas era simpatico notificar o utilizador que está a fazer um bom trabalho a partir do momento em que o rácio é superior a 10.
namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs.AddingBehaviours
{
    public enum Gender
    {
        None,
        Male,
        Female
    }

    public class User
    {
        public Guid Id { get; }

        public string Address { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
        
        public long Phone { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }
        
        public int RegionCode { get; set; }

        public double Ratio { get; set; }

        //Vamos adicionar os comportamentos

        public void Upload(string content)
        {
            Ratio++;
            Console.WriteLine($"O conteudo {content} foi enviado.{(Ratio > 10 ? "Parabéns, Tem um rácio elevado" : "")}");
        }

        public string Download(string id)
        {
            if (Ratio < 0.2) Console.WriteLine("Não pode transferir conteudo");
            else
            {
                Ratio -= 0.2;
                Console.WriteLine($"O conteúdo com o id {id} foi transferido.");
            }
            return string.Empty;
        }

        public User(string name, string email, Gender gender, long phone, int regionCode)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Gender = gender;
            Phone = phone;
            RegionCode = regionCode;
            Ratio = 1.0;
        }

       public User(string name, string email, Gender gender, long phone) : this (name, email, gender, phone, 351) { }

        public User(string name, Gender gender, long phone) : this(name, "", gender, phone) {}
        //E temos o nosso comportamento. Vamos testar?
    }
}
