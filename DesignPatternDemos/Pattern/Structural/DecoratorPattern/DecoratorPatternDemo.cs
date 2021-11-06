using DesignPatternDemos.Concrete.Car;
using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Enum;
using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Structural.DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public static void StartDecoratorPatternDemo()
        {
            IVehicle myCar = new Saloon(new StandardEngine(1300));
            myCar.Paint(VehicleColour.Blue);
            Console.WriteLine(myCar);

            //Decorate car with additional features
            myCar = new AirConditionedVehicle(myCar);
            Console.WriteLine(myCar);

            myCar = new AlloyWheelVehicle(myCar);
            Console.WriteLine(myCar);

            myCar = new LeatherSeatedVehicle(myCar);
            Console.WriteLine(myCar);

            myCar = new MetallicPaintVehicle(myCar);
            Console.WriteLine(myCar);

            myCar = new SatNavVehicle(myCar);
            Console.WriteLine(myCar);
        }
    }
}
