using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Behavioural.StrategyPattern
{
    public interface IGearboxStrategy
    {
        void EnsureCorrectGear(IEngine engine, int speed);
    }
}
