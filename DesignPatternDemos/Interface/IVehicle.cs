using DesignPatternDemos.Enum;

namespace DesignPatternDemos.Interface
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
        void CleanInterior();
        void CleanExteriorBody();
        void PolishWindows();
        void TakeTestDrive();
        int Price { get; }
    }
}
