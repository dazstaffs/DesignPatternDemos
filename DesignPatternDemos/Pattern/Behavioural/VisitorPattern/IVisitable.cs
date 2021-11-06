namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public interface IVisitable
    {
        void AcceptEngineVisitor(IEngineVisitor visitor);
    }
}
