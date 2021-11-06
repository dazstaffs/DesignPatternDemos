
using DesignPatternDemos.Enum;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Abstract
{
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColour colour;

        public AbstractVehicle(IEngine engine)
        {
            this.engine = engine;
        }

        public AbstractVehicle(IEngine engine, VehicleColour vehicleColour)
        {
            this.engine = engine;
            this.colour = vehicleColour;
        }

        public virtual IEngine Engine => engine;

        public virtual VehicleColour Colour
        {
            get => colour;
        }

        public abstract int Price { get; }

        public void CleanExteriorBody()
        {
            Console.WriteLine("Cleaning exterior body");
        }

        public void CleanInterior()
        {
            Console.WriteLine("Cleaning Interior");
        }

        public void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }

        public void PolishWindows()
        {
            Console.WriteLine("Polishing Windows");
        }

        public void TakeTestDrive()
        {
            Console.WriteLine("Taking for test drive....");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({this.Engine.GetType().Name} ({this.engine.Size}), {this.colour}, price {this.Price})";
        }
    }
}
