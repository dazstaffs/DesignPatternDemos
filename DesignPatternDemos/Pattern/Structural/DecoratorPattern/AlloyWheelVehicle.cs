using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public class AlloyWheelVehicle : AbstractVehicleOption
    {
        public AlloyWheelVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 250;
    }
}
