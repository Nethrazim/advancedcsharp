using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegates
{
    public class ContravarianceWithNonGenericDelegates : DelegateSample
    {
        class Vehicle
        {
            public void ShowVehicle(Vehicle myVehicle)
            {
                Console.WriteLine("Vehicle.ShowVehicle is called");
                Console.WriteLine("myVehicle.GetHasCode() is: {0}", myVehicle.GetHashCode());
            }
        }

        class Bus : Vehicle
        {
            public void ShowBus(Bus myBus)
            {
                Console.WriteLine("Bus.ShowBus is called.");
                Console.WriteLine("myBus.GetHasCode() is: {0}", myBus.GetHashCode());
            }
        }

        delegate void BusDelegate(Bus bus);
        public override void Run()
        {
            Bus bus = new Bus();
            Vehicle vehicle = new Vehicle();

            BusDelegate busDelegate = bus.ShowBus;
            BusDelegate vehicleDelegate = vehicle.ShowVehicle;

            busDelegate(bus);
            vehicleDelegate.Invoke(bus);
        }
    }
}
