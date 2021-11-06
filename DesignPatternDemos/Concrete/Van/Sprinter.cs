using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete.Van
{
    public class Sprinter : AbstractVan
    {
        public Sprinter(Engine engine) : base(engine)
        {

        }

        public override int Price => 10000;
    }
}
