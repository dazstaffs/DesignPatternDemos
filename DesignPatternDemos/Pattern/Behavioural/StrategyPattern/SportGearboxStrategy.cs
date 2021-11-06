using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Behavioural.StrategyPattern
{
    public class SportGearboxStrategy : IGearboxStrategy
    {
        public void EnsureCorrectGear(IEngine engine, int speed)
        {
            int engineSize = engine.Size;
            bool turbo = engine.Turbo;

            Console.WriteLine($"Working out correct gear at {speed}mph for the SPORT gearbox");
        }
    }
}
