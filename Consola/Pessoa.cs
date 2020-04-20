using Common;
using System;

namespace Classes
{
    #region P1
    public class RegistoPessoa
    {
        public static void RegistarPessoa(ref long cc, ref string nome, ref int idade,
                                                              ref string email, ref long telefone, ref char genero)
        {
            var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
            if (tempCC > 0) cc = tempCC;

            var tempNome = InputRequest.RequestString("Introduza o nome");
            if (!string.IsNullOrEmpty(tempNome)) nome = tempNome;

            var tempIdade = InputRequest.RequestInteger("Introduza a idade");
            if (tempIdade > 0 && tempIdade < 100) idade = tempIdade;

            var tempEmail = InputRequest.RequestString("Introduza o email");
            if (!string.IsNullOrEmpty(tempEmail)) email = tempEmail;

            var tempTel = InputRequest.RequestLong("Introduza número de telefone");
            if (tempTel.ToString().Length == 9) telefone = tempTel;

            var tempGenero = InputRequest.RequestCharacter("Introduza o género");
            if (tempGenero == 'M' || tempGenero == 'F') genero = tempGenero;
        }

        public static void AlterarNome(ref string nome)
        {
            string novoNome = InputRequest.RequestString("Insira o novo nome");
            if (!string.IsNullOrEmpty(novoNome)) nome = novoNome;
        }

        public static void AlterarCC(ref long cc)
        {
            var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
            if (tempCC > 0) cc = tempCC;
        }

        public static void AlterarIdade(ref int age)
        {
            var tempIdade = InputRequest.RequestInteger("Introduza a idade");
            if (tempIdade > 0 && tempIdade < 75) age = tempIdade;
        }

        public static void AlterarTelefone(ref long tel)
        {
            var tempTel = InputRequest.RequestLong("Introduza número de telefone");
            if (tempTel.ToString().Length == 9) tel = tempTel;
        }

        public static void AlterarEmail(ref string email)
        {
            var tempEmail = InputRequest.RequestString("Introduza o email");
            if (!string.IsNullOrEmpty(tempEmail)) email = tempEmail;
        }

        public static void AlterarSexo(ref char sexo)
        {
            var tempSexo = InputRequest.RequestCharacter("Introduza o sexo");
            if (tempSexo == 'M' || tempSexo == 'F') sexo = tempSexo;
        }

        public static void RegistarPessoa(ref long cc, ref string digitosControlo, ref string nome, ref int idade, ref string email, ref long telefone, ref int telefoneRegiao, ref char genero)
        {
            var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
            if (tempCC > 0) cc = tempCC;

            var tempDc = InputRequest.RequestString("Introduza os digitos de controlo");
            if (!string.IsNullOrEmpty(tempDc)) digitosControlo = tempDc;

            var tempNome = InputRequest.RequestString("Introduza o nome");
            if (!string.IsNullOrEmpty(tempNome)) nome = tempNome;

            var tempIdade = InputRequest.RequestInteger("Introduza a idade");
            if (tempIdade > 0 && tempIdade < 75) idade = tempIdade;

            var tempEmail = InputRequest.RequestString("Introduza o email");
            if (!string.IsNullOrEmpty(tempEmail)) email = tempEmail;

            var tempTel = InputRequest.RequestLong("Introduza número de telefone");
            if (tempTel.ToString().Length == 9) telefone = tempTel;

            var tempRegiao = InputRequest.RequestInteger("Introduza o código de região telefónico");
            if (tempRegiao > 0 && tempRegiao < 1000) idade = tempRegiao;

            var tempGenero = InputRequest.RequestCharacter("Introduza o género");
            if (tempGenero == 'M' || tempGenero == 'F') genero = tempGenero;

        }

        public static void ApresentarPessoa(ref long cc, ref string nome, ref int idade, ref string email, ref long telefone, ref char genero)
        {
            Console.WriteLine($"CC: {cc}\nNome: {nome}\nidade: {idade}\nemail: {email}\ntelefone: {telefone}\ngenero: {genero}");
        }
    }
    #endregion
    #region P2 
    //public class Pessoa
    //{
    //    /// <summary>
    //    /// Cartão de cidadão
    //    /// </summary>
    //    public long cc;
    //    public string digitosDeControlo;
    //    public string nome;
    //    public int idade;
    //    public long telefone;
    //    public int codigoRegiaoTelefone;
    //    public string email;
    //    public char genero;
    //}
    //public class GestorDePessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var p = new Pessoa();

    //        var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        if (tempCC > 0) p.cc = tempCC;

    //        var tempNome = InputRequest.RequestString("Introduza o nome");
    //        if (!string.IsNullOrEmpty(tempNome)) p.nome = tempNome;

    //        var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //        if (tempIdade > 0 && tempIdade < 75) p.idade = tempIdade;

    //        var tempEmail = InputRequest.RequestString("Introduza o email");
    //        if (!string.IsNullOrEmpty(tempEmail)) p.email = tempEmail;

    //        var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //        if (tempTel.ToString().Length == 9) p.telefone = tempTel;

    //        var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //        if (tempGenero == 'M' || tempGenero == 'F') p.genero = tempGenero;

    //        return p;
    //    }

    //    public static void AlterarNome(Pessoa p)
    //    {
    //        string novoNome = InputRequest.RequestString("Insira o novo nome");
    //        if (!string.IsNullOrEmpty(novoNome)) p.nome = novoNome;
    //    }

    //    public static void AlterarCC(Pessoa p)
    //    {
    //        var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        if (tempCC > 0) p.cc = tempCC;
    //    }

    //    public static void AlterarIdade(Pessoa p)
    //    {
    //        var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //        if (tempIdade > 0 && tempIdade < 75) p.idade = tempIdade;
    //    }

    //    public static void AlterarTelefone(Pessoa p)
    //    {
    //        var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //        if (tempTel.ToString().Length == 9) p.telefone = tempTel;
    //    }

    //    public static void AlterarEmail(Pessoa p)
    //    {
    //        var tempEmail = InputRequest.RequestString("Introduza o email");
    //        if (!string.IsNullOrEmpty(tempEmail)) p.email = tempEmail;
    //    }

    //    public static void AlterarGenero(Pessoa p)
    //    {
    //        var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //        if (tempGenero == 'M' || tempGenero == 'F') p.genero = tempGenero;
    //    }

    //    //public static void RegistarPessoa()
    //    //{
    //    //    var p = new Pessoa();
    //    //    var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //    //    if (tempCC > 0) p.cc = tempCC;

    //    //    var tempDc = InputRequest.RequestString("Introduza os digitos de controlo");
    //    //    if (!string.IsNullOrEmpty(tempDc)) p.digitosDeControlo = tempDc;

    //    //    var tempNome = InputRequest.RequestString("Introduza o nome");
    //    //    if (!string.IsNullOrEmpty(tempNome)) p.nome = tempNome;

    //    //    var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //    //    if (tempIdade > 0 && tempIdade < 75) p.idade = tempIdade;

    //    //    var tempEmail = InputRequest.RequestString("Introduza o email");
    //    //    if (!string.IsNullOrEmpty(tempEmail)) p.email = tempEmail;

    //    //    var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //    //    if (tempTel.ToString().Length == 9) p.telefone = tempTel;

    //    //    var tempRegiao = InputRequest.RequestInteger("Introduza o código de região telefónico");
    //    //    if (tempRegiao > 0 && tempRegiao < 1000) p.codigoRegiaoTelefone = tempRegiao;

    //    //    var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //    //    if (tempGenero == 'M' || tempGenero == 'F') p.genero = tempGenero;
    //    //    return p;
    //    //}

    //    public static void ApresentarPessoa(Pessoa p)
    //    {
    //        Console.WriteLine($"CC: {p.cc}\nNome: {p.nome}\nidade: {p.idade}\nemail: {p.email}\ntelefone: {p.telefone}\ngenero: {p.genero}");
    //    }
    //}
    //#endregion
    //#region P3 
    //public class Pessoa
    //{
    //    private long cc;

    //    public void SetCartaoCidadao(long cc)
    //    {
    //        if (cc.ToString().Length == 8)
    //            this.cc = cc;
    //    }

    //    public long GetCartaoCidadao()
    //    {
    //        return cc;
    //    }
    //    private string digitosDeControlo;

    //    public string GetDigitosDeControlo()
    //    {
    //        return digitosDeControlo;
    //    }

    //    public void SetDigitosDeControlo(string digitosDeControlo)
    //    {
    //        if (digitosDeControlo.Length == 4)
    //        {
    //            this.digitosDeControlo = digitosDeControlo;
    //        }
    //    }

    //    private string nome;

    //    public string GetNome()
    //    {
    //        return nome;
    //    }

    //    public void SetNome(string nome)
    //    {
    //        if (!string.IsNullOrEmpty(nome))
    //        {
    //            this.nome = nome;
    //        }
    //    }

    //    private int idade;

    //    public int GetIdade()
    //    {
    //        return this.idade;
    //    }

    //    public void SetIdade(int idade)
    //    {
    //        if (idade > 0 && idade < 75) this.idade = idade;
    //    }

    //    private long telefone;

    //    public long GetTelefone()
    //    {
    //        return telefone;
    //    }

    //    public void SetTelefone(long telefone)
    //    {
    //        if (telefone.ToString().Length == 9) this.telefone = telefone;
    //    }

    //    private string email;

    //    public string GetEmail()
    //    {
    //        return email;
    //    }

    //    public void SetEmail(string email)
    //    {
    //        if (!string.IsNullOrEmpty(email)) this.email = email;
    //    }

    //    private char genero;

    //    public char GetGenero()
    //    {
    //        return genero;
    //    }

    //    public void SetGenero(char genero)
    //    {
    //        if (genero == 'M' || genero == 'F') this.genero = genero;
    //    }

    //    private int codigoRegiaoTelefone;

    //    public int GetCodigoRegiaoTelefone()
    //    {
    //        return codigoRegiaoTelefone;
    //    }

    //    public void SetCodigoRegiaoTelefone(int codigoRegiaoTelefone)
    //    {
    //        this.codigoRegiaoTelefone = codigoRegiaoTelefone;
    //    }

    //    public string GetTelefoneCompleto()
    //    {
    //        return $"+{codigoRegiaoTelefone} {telefone}";
    //    }
    //}

    //public class GestorDePessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var p = new Pessoa();

    //        var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        p.SetCartaoCidadao(tempCC);

    //        var tempNome = InputRequest.RequestString("Introduza o nome");
    //        p.SetNome(tempNome);

    //        var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //        p.SetIdade(tempIdade);


    //        var tempEmail = InputRequest.RequestString("Introduza o email");
    //        p.SetEmail(tempEmail);

    //        var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //        p.SetTelefone(tempTel);

    //        var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //        p.SetGenero(tempGenero);

    //        return p;
    //    }

    //    //public static void RegistarPessoa()
    //    //{
    //    //    var p = new Pessoa();
    //    //    var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //    //    if (tempCC > 0) p.cc = tempCC;

    //    //    var tempDc = InputRequest.RequestString("Introduza os digitos de controlo");
    //    //    if (!string.IsNullOrEmpty(tempDc)) p.digitosDeControlo = tempDc;

    //    //    var tempNome = InputRequest.RequestString("Introduza o nome");
    //    //    if (!string.IsNullOrEmpty(tempNome)) p.nome = tempNome;

    //    //    var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //    //    if (tempIdade > 0 && tempIdade < 75) p.idade = tempIdade;

    //    //    var tempEmail = InputRequest.RequestString("Introduza o email");
    //    //    if (!string.IsNullOrEmpty(tempEmail)) p.email = tempEmail;

    //    //    var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //    //    if (tempTel.ToString().Length == 9) p.telefone = tempTel;

    //    //    var tempRegiao = InputRequest.RequestInteger("Introduza o código de região telefónico");
    //    //    if (tempRegiao > 0 && tempRegiao < 1000) p.codigoRegiaoTelefone = tempRegiao;

    //    //    var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //    //    if (tempGenero == 'M' || tempGenero == 'F') p.genero = tempGenero;
    //    //    return p;
    //    //}

    //    public static void ApresentarPessoa(Pessoa p)
    //    {
    //        Console.WriteLine($"CC: {p.cc}\nNome: {p.nome}\nidade: {p.idade}\nemail: {p.email}\ntelefone: {p.telefone}\ngenero: {p.genero}");
    //    }
    //}


    //#endregion

    //#region P4
    //public class Pessoa
    //{
    //    public long cartaoCidadao;
    //    public long CartaoCidadao
    //    {
    //        get 
    //        {
    //            return cartaoCidadao;
    //        }
    //        set 
    //        {
    //            if (value.ToString().Length == 8)
    //                cartaoCidadao = value;
    //        }
    //    }

    //    private string digitosDeControlo;

    //    public string DigitosDeControlo
    //    {
    //        get
    //        {
    //            return digitosDeControlo;
    //        }
    //        set
    //        {
    //            if (value.Length == 4)
    //                digitosDeControlo = value;
    //        }
    //    }

    //    private string nome;

    //    public string Nome
    //    {
    //        get
    //        {
    //            return nome;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //            {
    //                this.nome = value;
    //            }
    //        }
    //    }

    //    public string Morada { get; set; }

    //    private int idade;
    //    public int Idade
    //    {
    //        get
    //        {
    //            return idade;
    //        }
    //        set
    //        {
    //            if (value > 0 && value < 75) this.idade = value;
    //        }
    //    }

    //    private long telefone;
    //    public long Telefone
    //    {
    //        get
    //        {
    //            return telefone;
    //        }
    //        set
    //        {
    //            if (value.ToString().Length == 9) this.telefone = value;
    //        }
    //    }

    //    private string email;
    //    public string Email
    //    {
    //        get
    //        {
    //            return email;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value)) this.email = value;
    //        }
    //    }

    //    private char genero;

    //    public char Genero
    //    {
    //        get
    //        {
    //            return genero;
    //        }
    //        set
    //        {
    //            if (value == 'M' || value == 'F') this.genero = value;
    //        }
    //    }

    //    public int RegiaoTelefone { get; set; }

    //    public string TelefoneCompleto
    //    {
    //        get
    //        {
    //            return $"+{RegiaoTelefone} {Telefone}";
    //        }
    //    }


    //}

    //public class GestorDeOutrasPessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var p = new Pessoa();
    //        p.CartaoCidadao = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        p.Nome = InputRequest.RequestString("Introduza o nome");
    //        p.Genero = InputRequest.RequestCharacter("Introduza o género");
    //        return p;
    //    }
    //}


    //#endregion

    //#region P5
    //public class Pessoa
    //{
    //    public long cartaoCidadao;
    //    public long CartaoCidadao
    //    {
    //        get => cartaoCidadao;
    //        set => cartaoCidadao = (value.ToString().Length == 8) ? value : cartaoCidadao;
    //    }

    //    private string digitosDeControlo;

    //    public string DigitosDeControlo
    //    {
    //        get => digitosDeControlo;
    //        set => digitosDeControlo = (value.Length == 4) ? value : digitosDeControlo;
    //    }

    //    private string nome;

    //    public string Nome
    //    {
    //        get
    //        {
    //            return nome;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //            {
    //                this.nome = value;
    //            }
    //        }
    //    }

    //    public string Morada { get; set; }

    //    private int idade;
    //    public int Idade
    //    {
    //        get
    //        {
    //            return idade;
    //        }
    //        set
    //        {
    //            if (value > 0 && value < 75) this.idade = value;
    //        }
    //    }

    //    private long telefone;
    //    public long Telefone
    //    {
    //        get
    //        {
    //            return telefone;
    //        }
    //        set
    //        {
    //            if (value.ToString().Length == 9) this.telefone = value;
    //        }
    //    }

    //    private string email;
    //    public string Email
    //    {
    //        get
    //        {
    //            return email;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value)) this.email = value;
    //        }
    //    }

    //    private char genero;

    //    public char Genero
    //    {
    //        get
    //        {
    //            return genero;
    //        }
    //        set
    //        {
    //            if (value == 'M' || value == 'F') this.genero = value;
    //        }
    //    }

    //    public int RegiaoTelefone { get; set; }

    //    public string TelefoneCompleto
    //    {
    //        get
    //        {
    //            return $"+{RegiaoTelefone} {Telefone}";
    //        }
    //    }


    //}

    //public class GestorDeOutrasPessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var p = new Pessoa();
    //        p.CartaoCidadao = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        p.Nome = InputRequest.RequestString("Introduza o nome");
    //        p.Genero = InputRequest.RequestCharacter("Introduza o género");
    //        return p;
    //    }
    //}


    //#endregion
    #endregion
    #region P6
    //public class Pessoa
    //{

    //    public Pessoa() { }

    //    public Pessoa(long cc, string digitosControlo, string nome, string morada, int idade, long telefone, string email, int codigoRegiao, char genero)
    //    {
    //        this.cartaoCidadao = cc;
    //        this.digitosDeControlo = digitosControlo;
    //        this.nome = nome;
    //        this.Morada = morada;
    //        this.idade = idade;
    //        this.telefone = telefone;
    //        this.RegiaoTelefone = codigoRegiao;
    //        this.email = email;
    //        this.genero = genero;
    //    }

    //    public Pessoa(long cc, string digitosControlo, string nome, int idade, long telefone, string email, char genero)
    //    {
    //        this.cartaoCidadao = cc;
    //        this.digitosDeControlo = digitosControlo;
    //        this.nome = nome;
    //        this.Morada = "";
    //        this.idade = idade;
    //        this.telefone = telefone;
    //        this.RegiaoTelefone = 351;
    //        this.email = email;
    //        this.genero = genero;
    //    }

    //    public Pessoa(long cc, string digitosControlo, string nome, DateTime dataNascimento, long telefone, string email, char genero)
    //    {
    //        this.cartaoCidadao = cc;
    //        this.digitosDeControlo = digitosControlo;
    //        this.nome = nome;
    //        this.Morada = "";
    //        this.idade = DateTime.UtcNow.Year - dataNascimento.Year;
    //        this.telefone = telefone;
    //        this.RegiaoTelefone = 351;
    //        this.email = email;
    //        this.genero = genero;
    //    }
    //    public long cartaoCidadao;
    //    public long CartaoCidadao
    //    {
    //        get => cartaoCidadao;
    //        set => cartaoCidadao = (value.ToString().Length == 8) ? value : cartaoCidadao;
    //    }

    //    private string digitosDeControlo;

    //    public string DigitosDeControlo
    //    {
    //        get => digitosDeControlo;
    //        set => digitosDeControlo = (value.Length == 4) ? value : digitosDeControlo;
    //    }

    //    private string nome;

    //    public string Nome
    //    {
    //        get
    //        {
    //            return nome;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //            {
    //                this.nome = value;
    //            }
    //        }
    //    }

    //    public string Morada { get; set; }

    //    private int idade;
    //    public int Idade
    //    {
    //        get
    //        {
    //            return idade;
    //        }
    //        set
    //        {
    //            if (value > 0 && value < 75) this.idade = value;
    //        }
    //    }

    //    private long telefone;
    //    public long Telefone
    //    {
    //        get
    //        {
    //            return telefone;
    //        }
    //        set
    //        {
    //            if (value.ToString().Length == 9) this.telefone = value;
    //        }
    //    }

    //    private string email;
    //    public string Email
    //    {
    //        get
    //        {
    //            return email;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value)) this.email = value;
    //        }
    //    }

    //    private char genero;

    //    public char Genero
    //    {
    //        get
    //        {
    //            return genero;
    //        }
    //        set
    //        {
    //            if (value == 'M' || value == 'F') this.genero = value;
    //        }
    //    }

    //    public int RegiaoTelefone { get; set; }

    //    public string TelefoneCompleto
    //    {
    //        get
    //        {
    //            return $"+{RegiaoTelefone} {Telefone}";
    //        }
    //    }


    //}

    //public class GestorDeOutrasPessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var p = new Pessoa();
    //        p.CartaoCidadao = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        p.Nome = InputRequest.RequestString("Introduza o nome");
    //        p.Genero = InputRequest.RequestCharacter("Introduza o género");
    //        return p;
    //    }
    //}


    #endregion









    //#region P2 

    /////// <summary>
    /////// Assim, podemos abstrairnos de todos os campos e focarmo-nos na lógica...
    /////// </summary>
    //public class Pessoa
    //{
    //    public long cc;
    //    public string nome;
    //    public int idade;
    //    public string email;
    //    public long telefone;
    //    public char genero;
    //}

    //public static class ControladorDePessoas
    //{
    //    public static Pessoa RegistarPessoa()
    //    {
    //        var pessoa = new Pessoa();
    //        var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        if (tempCC > 0) pessoa.cc = tempCC;

    //        var tempNome = InputRequest.RequestString("Introduza o nome");
    //        if (!string.IsNullOrEmpty(tempNome)) pessoa.nome = tempNome;

    //        var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //        if (tempIdade > 0 && tempIdade < 75) pessoa.idade = tempIdade;

    //        var tempEmail = InputRequest.RequestString("Introduza o email");
    //        if (!string.IsNullOrEmpty(tempEmail)) pessoa.email = tempEmail;

    //        var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //        if (tempTel.ToString().Length == 9) pessoa.telefone = tempTel;

    //        var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //        if (tempGenero == 'M' || tempGenero == 'F') pessoa.genero = tempGenero;

    //        return pessoa;
    //    }

    //    public static void AlterarNome(Pessoa pessoa)
    //    {
    //        var tempNome = InputRequest.RequestString("Introduza o nome");
    //        if (!string.IsNullOrEmpty(tempNome)) pessoa.nome = tempNome;
    //    }

    //    public static void AlterarCC(Pessoa pessoa)
    //    {
    //        var tempCC = InputRequest.RequestLong("Introduza o número de cartão de cidadão");
    //        if (tempCC > 0) pessoa.cc = tempCC;
    //    }

    //    public static void AlterarIdade(Pessoa pessoa)
    //    {
    //        var tempIdade = InputRequest.RequestInteger("Introduza a idade");
    //        if (tempIdade > 0 && tempIdade < 75) pessoa.idade = tempIdade;
    //    }

    //    public static void AlterarTelefone(Pessoa pessoa)
    //    {
    //        var tempTel = InputRequest.RequestLong("Introduza número de telefone");
    //        if (tempTel.ToString().Length == 9) pessoa.telefone = tempTel;
    //    }

    //    public static void AlterarEmail(Pessoa pessoa)
    //    {
    //        var tempEmail = InputRequest.RequestString("Introduza o email");
    //        if (!string.IsNullOrEmpty(tempEmail)) pessoa.email = tempEmail;
    //    }

    //    public static void AlterarGenero(Pessoa pessoa)
    //    {
    //        var tempGenero = InputRequest.RequestCharacter("Introduza o género");
    //        if (tempGenero == 'M' || tempGenero == 'F') pessoa.genero = tempGenero;
    //    }

    //    public static void ApresentarPessoa(Pessoa pessoa)
    //    {
    //        Console.WriteLine($"CC: {pessoa.cc}\nNome: {pessoa.nome}\nidade: {pessoa.idade}\nemail: {pessoa.email}\ntelefone: {pessoa.telefone}\ngenero: {pessoa.genero}");
    //    }
    //}

    //#endregion

    //#region P3
    ////public class Pessoa
    ////{
    ////     private long cc;

    ////     public long GetCartaoCidadao()
    ////     {
    ////         return cc;
    ////     }

    ////     public void SetCartaoCidadao(long cc)
    ////     {
    ////         if (cc > 0) this.cc = cc;
    ////     }

    ////     private string nome;

    ////     public string GetNome()
    ////     {
    ////         return nome;
    ////     }

    ////     public void SetNome(string nome)
    ////     {
    ////         if (!string.IsNullOrEmpty(nome)) this.nome = nome;
    ////     }

    ////     private int idade;

    ////     public int GetIdade()
    ////     {
    ////         return this.idade;
    ////     }

    ////     public void SetIdade(int idade)
    ////     {
    ////         if (idade > 0 && idade < 75) this.idade = idade;
    ////     }

    ////     private string email;

    ////     public string GetEmail()
    ////     {
    ////         return email;
    ////     }

    ////     public void SetEmail(string email)
    ////     {
    ////         if (!string.IsNullOrEmpty(email)) this.email = email;
    ////     }

    ////     private long telefone;

    ////     public long GetTelefone()
    ////     {
    ////         return telefone;
    ////     }

    ////     public void SetTelefone(long telefone)
    ////     {
    ////         if (telefone.ToString().Length == 9) this.telefone = telefone;
    ////     }

    ////     private char genero;

    ////     public char GetGenero()
    ////     {
    ////         return genero;
    ////     }

    ////     public void SetGenero(char genero)
    ////     {
    ////         if (genero == 'M' || genero == 'F') this.genero = genero;
    ////     }
    //// }
    //#endregion

    #region P4
    ///// <summary>
    ///// Mas pode ficar melhor
    ///// </summary>
    public class Pessoa
    {
        public Pessoa(long cc, string nome)
        {
            this.cc = cc;
            this.nome = nome;
            this.idade = 0;
        }

        private long cc;
        public long CartaoCidadao
        {
            get
            {
                return cc;
            }
            set
            {
                if (value > 0) cc = value;
            }
        }

        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) nome = value;
            }
        }

        private int idade;
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value > 0 && value < 75) idade = value;
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
                if (!string.IsNullOrEmpty(value)) email = value;
            }
        }

        private long telefone;
        public long Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.ToString().Length == 9) telefone = value;
            }
        }

        public string Morada { get; set; }

        private char genero;
        public char Genero
        {
            get => genero;
            set
            {
                genero = (value == 'M' || value == 'F') ? ((Nome.EndsWith('o') ? value : genero)) : genero;
            }
        }

        #endregion

        #region P5
        /////// <summary>
        /////// E agora adiciona-se um pouco de açucar sintático
        /////// </summary>
        //public class Pessoa
        //{
        //    private long cc;
        //    public long CartaoCidadao
        //    {
        //        get => cc;
        //        set => cc = value > 0 ? value : cc;
        //    }

        //    private string nome;
        //    public string Nome
        //    {
        //        get => nome;
        //        set => nome = !string.IsNullOrEmpty(value) ? value : nome;
        //    }

        //    private int idade;
        //    public int Idade
        //    {
        //        get => idade;
        //        set => idade = (value > 0 && value < 75) ? value : idade;
        //    }


        //    private string email;
        //    public string Email
        //    {
        //        get => email;
        //        set => email = !string.IsNullOrEmpty(value) ? value : email;
        //    }

        //    private long telefone;
        //    public long Telefone
        //    {
        //        get => telefone;
        //        set => telefone = (value.ToString().Length == 9) ? value:telefone;
        //    }

        //    public string Morada { get; set; }

        //    private char genero;
        //    public char Genero
        //    {
        //        get => genero;
        //        set => genero = (value == 'M' || value == 'F') ? value : genero;
        //    }
        //}
        #endregion

        #region P6 
        ///// <summary>
        ///// E agora adiciona-se um pouco de açucar sintático
        ///// </summary>
        //public class Pessoa
        //{
        //    private long cc;
        //    public long CartaoCidadao
        //    {
        //        get => cc;
        //        set => cc = value > 0 ? value : cc;
        //    }

        //    private string nome;
        //    public string Nome
        //    {
        //        get => nome;
        //        set => nome = !string.IsNullOrEmpty(value) ? value : nome;
        //    }

        //    private int idade;
        //    public int Idade
        //    {
        //        get => idade;
        //        set => idade = (value > 0 && value < 75) ? value : idade;
        //    }


        //    private string email;
        //    public string Email
        //    {
        //        get => email;
        //        set => email = !string.IsNullOrEmpty(value) ? value : email;
        //    }

        //    private long telefone;
        //    public long Telefone
        //    {
        //        get => telefone;
        //        set => telefone = (value.ToString().Length == 9) ? value : telefone;
        //    }

        //    public string Morada { get; set; }

        //    private char genero;
        //    public char Genero
        //    {
        //        get => genero;
        //        set => genero = (value == 'M' || value == 'F') ? value : genero;
        //    }

        //    public Pessoa() { }

        //    public Pessoa(long cc, string nome, int idade, char genero)
        //    {
        //        CartaoCidadao = cc;
        //        Nome = nome;
        //        Idade = idade;
        //        Genero = genero;
        //    }

        //    public Pessoa(long cc, string nome,  char genero)
        //    {
        //        CartaoCidadao = cc;
        //        Nome = nome;
        //        Idade = 0;
        //        Genero = genero;
        //    }

        //    public Pessoa(long cc, string nome, DateTime dataNascimento, char genero)
        //    {
        //        CartaoCidadao = cc;
        //        Nome = nome;
        //        Idade = (DateTime.Now.Year - dataNascimento.Year);
        //        Genero = genero;
        //    }
        //}
        #endregion


        //#region P7

        //public struct CartaoCidadao
        //{
        //    public long Numero { get; }
        //    public long IdentificacaoFiscal { get; }
        //    public long IdentificacaoSegurancaSocial { get; }

        //    public CartaoCidadao(long numero, long nif, long niss)
        //    {
        //        Numero = numero;
        //        IdentificacaoFiscal = nif;
        //        IdentificacaoSegurancaSocial = niss;
        //    }
        //}



        //#endregion
    }
}
