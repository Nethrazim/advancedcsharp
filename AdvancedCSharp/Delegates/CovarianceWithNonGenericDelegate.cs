using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegates
{
    public class CovarianceWithNonGenericDelegate : DelegateSample
    {
      

        class Vehicle
        {
            public Vehicle CreateVehicle()
            {
                Vehicle myVehicle = new Vehicle();
                Console.WriteLine("Inside Vehicle.CreateVehicle, a vehicle object is created.");
                return myVehicle;
            }
        }

        class Bus : Vehicle {
            public Bus CreateBus()
            {
                Bus myBus = new Bus();
                Console.WriteLine("Inside Bus.CreateBus, a bus object is created.");
                return myBus;
            }
        }
        delegate Vehicle VehicleDelegate();

        public override void Run()
        {
            VehicleDelegate delegate_example = new VehicleDelegate(new Bus().CreateBus);
            delegate_example.Invoke();
        }
    }
}
