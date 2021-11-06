using DesignPatternDemos.Interface;
using DesignPatternDemos.Pattern.Behavioural.VisitorPattern;

namespace DesignPatternDemos.Abstract
{
    public class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;
        private Camshaft camshaft;
        private Piston piston;
        private SparkPlug[] sparkPlugs;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            this.camshaft = new Camshaft();
            this.piston = new Piston();
            this.sparkPlugs = new SparkPlug[] { new SparkPlug(), new SparkPlug(), new SparkPlug(), new SparkPlug() };
        }

        public int Size
        {
            get => size;
        }

        public bool Turbo
        {
            get => turbo;
        }

        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            camshaft.AcceptEngineVisitor(visitor);
            piston.AcceptEngineVisitor(visitor);
            foreach (SparkPlug sparkPlug in sparkPlugs)
            {
                sparkPlug.AcceptEngineVisitor(visitor);
            }
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }
    }
}
