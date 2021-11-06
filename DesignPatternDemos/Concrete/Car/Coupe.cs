using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete.Car
{
    public class Coupe : AbstractCar
    {
        public Coupe(Engine engine) : base(engine) { }

        public override int Price => 7000;
    }
}
