using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    class VisitorPatternDemo
    {
        internal static void StartVisitorPatternDemo()
        {
            IEngine engine = new StandardEngine(1300);
            engine.AcceptEngineVisitor(new EngineDiagnostics());
            engine.AcceptEngineVisitor(new EngineInventory());
        }
    }
}
