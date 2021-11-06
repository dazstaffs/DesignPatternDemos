using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Abstract
{
    public abstract class AbstractVan : AbstractVehicle
    {
        protected AbstractVan(IEngine engine) : base(engine)
        {

        }
    }
}
