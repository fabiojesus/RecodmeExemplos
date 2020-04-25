using DemonstracaoV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

//Neste exemplo temos uma interface de veiculo motorizado que força a implementação de um conjunto de comportamentos.
namespace Recodme.Formacao.DemonstracaoV2.ClassesAndInterfaces.ClassesAndStructs
{

    public interface IMotorizedVehicle
    {
        public void Start();
        public void Stop();
        public void Accelerate();
        public void Brake();
        public int LicensePlateYear { get; set; }
    }

    //A implementação de uma interface consiste no uso de : (dois pontos) seguido da interface.
    //Adicionamos também um método ao carro.
    public class Car : IMotorizedVehicle
    {
        public int LicensePlateYear { get; set; }
        public int SerialNumber { get; set; }
        public void TurnWheel() { }
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("The car has started");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Boat : IMotorizedVehicle
    {
        public int LicensePlateYear { get; set; }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("The boat has started");

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Plane : IMotorizedVehicle
    {
        public int LicensePlateYear { get; set; }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("The plane has started");

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Bike : IMotorizedVehicle
    {
        public int LicensePlateYear { get; set; }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("The bike has started");

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class InterfaceTester
    {
        public static void TestInterface()
        {
            //Um dos casos mais interessantes do uso de interfaces é a capacidade de expressarmos um tipo genérico através da sua identificação
            var vehicles = new List<IMotorizedVehicle>();
            //Podemos agora adicionar qualquer objeto de uma classe que implemente a interface
            vehicles.Add(new Boat());
            vehicles.Add(new Car());
            vehicles.Add(new Plane());
            vehicles.Add(new Bike());
        
            //E agora iteramos a lista para executar o método start
            foreach(var vehicle in vehicles)
            {
                vehicle.Start();
                //vehicle.TurnWheel(); //Não acontece nada porque de momento é um objeto identificado por IMotorizedVehicle que não tem a definiçao de turn wheel
            }

            //No entanto reparem no que acontece quando tentamos invocar o método turnwheel do carro
            DateTime d = DateTime.Now;
        }

        


    }

}
