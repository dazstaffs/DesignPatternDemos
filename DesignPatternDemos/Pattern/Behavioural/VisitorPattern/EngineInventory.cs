using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public class EngineInventory : IEngineVisitor
    {
        private int camshaftCount;
        private int pistonCount;
        private int sparkPlugCount;

        public EngineInventory()
        {
            this.camshaftCount = 0;
            this.pistonCount = 0;
            this.sparkPlugCount = 0;
        }

        public void Visit(Camshaft camshaft)
        {
            camshaftCount++;
        }

        public void Visit(IEngine engine)
        {
            Console.WriteLine($"The engine has: {camshaftCount} camshaft(s), {pistonCount} piston(s) and {sparkPlugCount} spark plug(s)");
        }

        public void Visit(Piston piston)
        {
            pistonCount++;
        }

        public void Visit(SparkPlug sparkPlug)
        {
            sparkPlugCount++;
        }
    }
}
