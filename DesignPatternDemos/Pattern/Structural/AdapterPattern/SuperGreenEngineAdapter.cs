using DesignPatternDemos.Abstract;
using DesignPatternDemos.Concrete.EngineType;

namespace DesignPatternDemos.Pattern.Structural.AdapterPattern
{

    public class SuperGreenEngineAdapter : AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine greenEngine) : base(greenEngine.Size, false)
        {

        }
    }
}
