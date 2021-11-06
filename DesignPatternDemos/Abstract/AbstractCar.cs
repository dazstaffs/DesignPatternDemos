using DesignPatternDemos.Interface;
using DesignPatternDemos.Pattern.Behavioural.StrategyPattern;

namespace DesignPatternDemos.Abstract
{
    public abstract class AbstractCar : AbstractVehicle
    {
        private IGearboxStrategy gearboxStrategy;

        public AbstractCar(IEngine engine) : base(engine)
        {
            gearboxStrategy = new StandardGearboxStrategy();
        }

        public virtual IGearboxStrategy IGearboxStrategy
        {
            set
            {
                gearboxStrategy = value;
            }

            get
            {
                return gearboxStrategy;
            }
        }

        public virtual int Speed
        {
            set
            {
                //Delegate to strategy in effect...
                gearboxStrategy.EnsureCorrectGear(Engine, value);
            }
        }
    }
}
