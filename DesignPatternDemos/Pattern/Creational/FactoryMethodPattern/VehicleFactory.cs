using DesignPatternDemos.Enum;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Creational.FactoryMethodPattern
{
    public abstract class VehicleFactory
    {
        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }

        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);

        public static IVehicle Make(Category category, DrivingStyle style, VehicleColour colour)
        {
            VehicleFactory factory = null;

            if (category == Category.Car)
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }
            return factory.Build(style, colour);
        }
    }
}
