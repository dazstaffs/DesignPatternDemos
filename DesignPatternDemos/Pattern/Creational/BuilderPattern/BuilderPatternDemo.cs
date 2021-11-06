using DesignPatternDemos.Abstract;
using DesignPatternDemos.Concrete.Car;
using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Creational.BuilderPattern
{
    public class BuilderPatternDemo
    {
        internal static void StartBuilderPatternDemo()
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle vehicle = director.Build(builder);
            Console.WriteLine(vehicle);
        }

    }
}
