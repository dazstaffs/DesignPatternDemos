using DesignPatternDemos.Enum;
using System;

namespace DesignPatternDemos.Interface
{
    public interface IVehicle:ICloneable
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
