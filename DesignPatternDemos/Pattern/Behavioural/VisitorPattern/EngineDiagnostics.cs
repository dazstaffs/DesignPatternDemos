using DesignPatternDemos.Interface;
using System;

namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public class EngineDiagnostics : IEngineVisitor
    {
        public void Visit(Camshaft camshaft)
        {
            Console.WriteLine("Diagnosing the camshaft");
        }

        public void Visit(IEngine engine)
        {
            Console.WriteLine("Diagnosing the engine");
        }

        public void Visit(Piston piston)
        {
            Console.WriteLine("Diagnosing the piston.");
        }

        public void Visit(SparkPlug sparkPlug)
        {
            Console.WriteLine("Diagosing a single sparkplug.");
        }
    }
}
