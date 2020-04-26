using System;

namespace Recodme.Formacao.DemonstracaoV2
{
    //Os atributos funcionam como metainformação acerca de um elemento. Vamos criar um.
    //É bastante simples. 
    //1. É uma classe normal, que deve sempre terminar em Attribute.
    //Deve ter um atributo chamado AttributeUsage, onde deverão colocar o que é afetado e se pode ter vários ou não

    //Vamos criar o primeiro que apenas afetará classes e não se pode repetir

    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class AlternativeNamedClassAttribute : Attribute
    {
        public string AlternativeName { get; set; }
    }

    //E agora um que se repita
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)]
    public class InterfacesThatCanBeImplementedAttribute : Attribute
    {
        public string Name { get; set; }
    }

    //E um que afete mais que as classes
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
    }

    //Vamos implementá-las?

    [Serializable] //Um dos atributos mais comuns
    [Author(Name ="Fábio")]
    [InterfacesThatCanBeImplemented(Name = "IVehicle")]
    [InterfacesThatCanBeImplemented(Name = "ICar")]
    [AlternativeNamedClass(AlternativeName ="Bus")]
    //Vamos tentar colocar uma que não pode ser repetida
    //[AlternativeNamedClass(AlternativeName ="Bus")]
    public class Car
    {
        //Vamos implementar uma propriedade e adicionar atributos. Começamos pelo autor
        [Author(Name = "Fábio")]
        //E agora uma só para classes
        //[InterfacesThatCanBeImplemented(Name ="IName")]
        public int LicensePlate { get; set; }
    }

    //E é praticamente o que se pode fazer com atributos, por enquanto...


}
