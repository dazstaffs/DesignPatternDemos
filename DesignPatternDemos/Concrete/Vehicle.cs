using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete
{
    public abstract class Vehicle : AbstractVehicle
    {
        public Vehicle(Engine engine) : base(engine)
        {
        }
    }
}
