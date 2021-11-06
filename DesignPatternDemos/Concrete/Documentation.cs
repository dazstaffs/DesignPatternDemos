using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Concrete
{
    public class Documentation
    {
        public static void PrintBrochure(IVehicle vehicle) => Console.WriteLine("Printing brochure...");
    }

}
