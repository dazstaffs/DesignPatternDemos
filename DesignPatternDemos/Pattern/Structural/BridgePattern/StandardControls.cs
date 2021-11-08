using DesignPatternDemos.Abstract;
using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Structural.BridgePattern
{
    public class StandardControls : AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine)
        {
        }
    }
}
