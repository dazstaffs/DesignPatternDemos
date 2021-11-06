using DesignPatternDemos.Concrete;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Structural.StructuralPattern
{
    public class VehicleFacade
    {
        public virtual void PrepareForSale(IVehicle vehicle)
        {
            Registration registration = new Registration(vehicle);
            registration.AllocateVehicleNumber();
            registration.AllocateLicensePlate();

            Documentation.PrintBrochure(vehicle);

            vehicle.CleanInterior();
            vehicle.CleanExteriorBody();
            vehicle.PolishWindows();
            vehicle.TakeTestDrive();
        }
    }
}
