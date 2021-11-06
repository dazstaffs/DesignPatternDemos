namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public class Camshaft : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
