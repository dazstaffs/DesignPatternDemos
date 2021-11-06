using DesignPatternDemos.Concrete.Car;
using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.StructuralPattern
{
    public class FacadePatternDemo
    {
        public static void StartFacadePatternDemo()
        {
            IVehicle vehicle = new Saloon(new StandardEngine(1800));
            VehicleFacade vehicleFacade = new VehicleFacade();
            vehicleFacade.PrepareForSale(vehicle);
        }
    }
}
