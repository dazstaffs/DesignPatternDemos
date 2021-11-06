using DesignPatternDemos.Abstract;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Creational.BuilderPattern
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            this.carInProgress = car;
        }

        public override IVehicle Vehicle => carInProgress;

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passnger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building car windows");
        }
    }
}
