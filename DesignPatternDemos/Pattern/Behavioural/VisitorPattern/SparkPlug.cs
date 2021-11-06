namespace DesignPatternDemos.Pattern.Behavioural.VisitorPattern
{
    public class SparkPlug : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
