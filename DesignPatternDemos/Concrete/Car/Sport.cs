using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete.Car
{
    public class Sport : AbstractCar
    {
        public Sport(Engine engine) : base(engine)
        {

        }

        public override int Price => 8000;
    }
}
