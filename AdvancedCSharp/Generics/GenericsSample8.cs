using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generics
{
    //Covariance with Generic Interfaces
    class GenericsSample8
    {
        class Vehicle {
            public virtual void ShowMe() { Console.WriteLine("Vehicle.ShowMe(). The hash code is: " + GetHashCode()); }
        }
        class Bus : Vehicle {
            public override void ShowMe() { Console.WriteLine("Bus.ShowMe(). The hash code is: " + GetHashCode()); }
        }

        public void Run()
        {
            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();

            Bus bus = new Bus();
            Bus bus2 = new Bus();

            List<Bus> busList = new List<Bus>() { bus, bus2 };
            IEnumerable<Bus> busEnumerable = busList;

            List<Vehicle>   vehicleList = new List<Vehicle>() { vehicle1, vehicle2 , bus, bus2};

            IEnumerable<Vehicle> vehicleEnumerable = busEnumerable;
            foreach (Vehicle vehicle in vehicleEnumerable)
            {
                vehicle.ShowMe();
            }

            foreach (Vehicle vehicle in vehicleList)
            {
                vehicle.ShowMe();
            }
        }
    }
}
