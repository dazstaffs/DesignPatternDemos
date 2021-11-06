using DesignPatternDemos.Enum;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Creational.FactoryMethodPattern
{
    class FactoryPatternMethodDemo
    {
        public static void StartFactroyMethodPatternDemo()
        {
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.Build(DrivingStyle.Economical, VehicleColour.Blue);
            Console.WriteLine(car);

            VehicleFactory vanFactory = new VanFactory();
            IVehicle van = vanFactory.Build(DrivingStyle.Powerful, VehicleColour.White);
            Console.WriteLine(van);

            IVehicle sporty = VehicleFactory.Make(Category.Car, DrivingStyle.Powerful, VehicleColour.Red);
            Console.WriteLine(sporty);
        }
    }
}
