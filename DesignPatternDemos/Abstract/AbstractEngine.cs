using DesignPatternDemos.Interface;
using DesignPatternDemos.Pattern.Behavioural.VisitorPattern;
using System;

namespace DesignPatternDemos.Abstract
{
    public class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;
        private Camshaft camshaft;
        private Piston piston;
        private SparkPlug[] sparkPlugs;
        private bool running;
        private int power;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            this.camshaft = new Camshaft();
            this.piston = new Piston();
            this.sparkPlugs = new SparkPlug[] { new SparkPlug(), new SparkPlug(), new SparkPlug(), new SparkPlug() };
            this.running = false;
            this.power = 0;
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

        public void DecreasePower()
        {
            if (running && power > 0)
            {
                power--;
                Console.WriteLine($"Decreasing power to {this.power}");
            }
        }

        public void IncreasePower()
        {
            if (running && power < 10)
            {
                power++;
                Console.WriteLine($"Increasing power to {this.power}");
            }
        }

        public void Start()
        {
            running = true;
            Console.WriteLine($"Engine running: {this.running}");
        }

        public void Stop()
        {
            running = false;
            power = 0;
            Console.WriteLine($"Engine running: {this.running}, power: {this.power}");
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }
    }
}
