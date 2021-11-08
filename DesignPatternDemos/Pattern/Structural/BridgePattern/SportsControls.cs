using DesignPatternDemos.Abstract;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Structural.BridgePattern
{
    public class SportsControls : AbstractDriverControls
    {
        public SportsControls(IEngine engine) : base(engine)
        {
        }

        public virtual void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
}
