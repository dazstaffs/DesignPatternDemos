using DesignPatternDemos.Concrete.Car;
using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Concrete.Van;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Creational.PrototypePattern
{
    public class VehicleManager
    {
        private IVehicle saloon, coupe, sport, sprinter, pickup;

        public virtual IVehicle CreateSaloon()
        {
            Console.WriteLine("Returning New Saloon");
            saloon = new Saloon(new StandardEngine(1300));
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            Console.WriteLine("Returning New Coupe");
            coupe = new Coupe(new StandardEngine(1300));
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            Console.WriteLine("Returning New Sport");
            sport = new Sport(new StandardEngine(1300));
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateSprinter()
        {
            Console.WriteLine("Returning New Sprinter");
            sprinter = new Sprinter(new StandardEngine(1300));
            return (IVehicle)sprinter.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            Console.WriteLine("Returning New Pickup");
            pickup = new Pickup(new StandardEngine(1300));
            return (IVehicle)pickup.Clone();
        }
    }
}
