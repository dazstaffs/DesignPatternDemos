using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public class AirConditionedVehicle : AbstractVehicleOption
    {
        public AirConditionedVehicle(IVehicle vehicle) : base(vehicle)
        {

        }

        public override int Price => decoratedVehicle.Price + 600;
    }
}
