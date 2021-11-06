using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public class SatNavVehicle : AbstractVehicleOption
    {
        public SatNavVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => this.decoratedVehicle.Price + 1500;

        public virtual string Destination
        {
            set { }
        }
    }
}
