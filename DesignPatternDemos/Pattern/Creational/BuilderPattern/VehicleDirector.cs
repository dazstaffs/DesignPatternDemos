using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Creational.BuilderPattern
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
