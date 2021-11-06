using DesignPatternDemos.Abstract;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Creational.BuilderPattern
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            this.vanInProgress = van;
        }

        public override IVehicle Vehicle => vanInProgress;

        public override void BuildBody()
        {
            Console.WriteLine("Building van body");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("Building van storage area");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building van chassis");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building van windows");
        }
    }
}
