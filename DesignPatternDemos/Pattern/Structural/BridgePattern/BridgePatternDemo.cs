using DesignPatternDemos.Concrete.EngineType;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Structural.BridgePattern
{
    public class BridgePatternDemo
    {
        public static void StartBridgePatternDemo()
        {
            IEngine engine = new StandardEngine(1300);
            StandardControls standardControls = new StandardControls(engine);
            standardControls.IgnitionOn();
            standardControls.Accelerate();
            standardControls.Brake();
            standardControls.IgnitionOff();

            SportsControls sportsControls = new SportsControls(engine);
            sportsControls.IgnitionOn();
            sportsControls.Accelerate();
            sportsControls.AccelerateHard();
            sportsControls.Brake();
            sportsControls.IgnitionOff();
        }
    }
}
