using DesignPatternDemos.Pattern.Behavioural.VisitorPattern;

namespace DesignPatternDemos.Interface
{
    public interface IEngine : IVisitable
    {
        int Size { get; }
        bool Turbo { get; }
    }
}
