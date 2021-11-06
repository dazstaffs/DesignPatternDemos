using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Concrete.Van;
using DesignPatternDemos.Enum;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Creational.FactoryMethodPattern
{
    public class VanFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Midrange || style == DrivingStyle.Economical)
            {
                return new Pickup(new StandardEngine(2200));
            }
            else
            {
                return new Sprinter(new TurboEngine(2500));
            }
        }
    }
}
