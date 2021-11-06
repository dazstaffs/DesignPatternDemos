using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Concrete
{
    public class Registration
    {
        private IVehicle vehicle;

        public Registration(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public virtual void AllocateLicensePlate() => Console.WriteLine("Allocating License Plate");
        public virtual void AllocateVehicleNumber() => Console.WriteLine("Allocating Vehicle Number");
    }
}
