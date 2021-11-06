using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete.Van
{
    public class Pickup : AbstractVan
    {
        public Pickup(Engine engine) : base(engine)
        {
        }

        public override int Price => 9000;
    }
}
