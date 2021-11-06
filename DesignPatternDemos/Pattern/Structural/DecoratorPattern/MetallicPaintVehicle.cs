using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public class MetallicPaintVehicle : AbstractVehicleOption
    {
        public MetallicPaintVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 750;
    }
}
