namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public class Piston : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
