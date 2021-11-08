using DesignPatternDemos.Concrete;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Creational.PrototypePattern
{
    public class PrototypePatternDemo
    {
        public static void StartPrototypePatternDemo()
        {
            VehicleManager vehicleManager = new VehicleManager();
            IVehicle saloon1 = vehicleManager.CreateSaloon();
            IVehicle saloon2 = vehicleManager.CreateSaloon();
            IVehicle pickup = vehicleManager.CreatePickup();
        }
    }
}
