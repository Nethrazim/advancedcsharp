using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    internal class GenericSample7
    {
        class Vehicle { }
        class Bus : Vehicle { }

        delegate TResult CovDelegate<out TResult>();
        delegate Bus ContraDelegate<in TResult>(TResult param);



        public void Run()
        {
            Console.WriteLine("Covariance");
            CovDelegate<Vehicle> covVehicle = new CovDelegate<Vehicle>(GetOneVehicle);
            covVehicle += GetOneBus;
            covVehicle();
            
            CovDelegate<Bus> covBus = GetOneBus;
            covBus();

            covVehicle = covBus;
            covVehicle();

            Console.WriteLine("ContraVariance");

            ContraDelegate<Bus> contra2Vehicle = SetOneVehicle;
            contra2Vehicle(new Bus());

        }

        private Bus SetOneVehicle(Vehicle vehicle) { return (Bus)vehicle; }
        private Bus SetOneBus(Bus bus) { return bus; }
        private Vehicle GetOneVehicle()
        {
            Console.WriteLine("Creating one vehicle and returning it.");
            return new Vehicle();
        }

        private Bus GetOneBus()
        {
            Console.WriteLine("Creating one bus and returning it.");
            return new Bus();
        }
    }
}
