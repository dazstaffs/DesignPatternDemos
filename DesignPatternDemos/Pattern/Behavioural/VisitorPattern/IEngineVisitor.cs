using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public interface IEngineVisitor
    {
        void Visit(Camshaft camshaft);
        void Visit(IEngine engine);
        void Visit(Piston piston);
        void Visit(SparkPlug sparkPlug);
    }
}
