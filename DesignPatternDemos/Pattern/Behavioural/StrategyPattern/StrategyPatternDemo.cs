using DesignPatternDemos.Abstract;
using DesignPatternDemos.Concrete.Car;
using DesignPatternDemos.Concrete.EngineType;
using System;

namespace DesignPatternDemos.Pattern.Behavioural.StrategyPattern
{
    public class StrategyPatternDemo
    {
        internal static void StartStrategyPatternDemo()
        {
            AbstractCar myCar = new Sport(new StandardEngine(2000));
            myCar.Speed = 20;
            myCar.Speed = 40;

            Console.WriteLine("Switching on sports mode gearbox");

            myCar.IGearboxStrategy = new SportGearboxStrategy();
            myCar.Speed = 40;
        }
    }
}
