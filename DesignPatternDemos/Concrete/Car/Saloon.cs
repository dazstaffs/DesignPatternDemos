using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete.Car
{
    public class Saloon : AbstractCar
    {

        public Saloon(Engine engine) : base(engine)
        {
        }

        public override int Price => 6000;
    }
}
