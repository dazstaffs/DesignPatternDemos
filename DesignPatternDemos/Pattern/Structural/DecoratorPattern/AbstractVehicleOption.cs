using DesignPatternDemos.Abstract;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public abstract class AbstractVehicleOption : AbstractVehicle
    {
        protected internal IVehicle decoratedVehicle;

        public AbstractVehicleOption(IVehicle vehicle) : base(vehicle.Engine, vehicle.Colour)
        {
            decoratedVehicle = vehicle;
        }
    }
}
