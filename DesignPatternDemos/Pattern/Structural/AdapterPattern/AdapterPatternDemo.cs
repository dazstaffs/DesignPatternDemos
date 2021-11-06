using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;

namespace DesignPatternDemos.Pattern.Structural.AdapterPattern
{
    public class AdapterPatternDemo
    {
        public static void StartAdapterPatternDemo()
        {
            IList<IEngine> engines = new List<IEngine>();
            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1600));
            engines.Add(new TurboEngine(2000));

            //Adapt new Engine
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));

            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);
            }
        }
    }
}
