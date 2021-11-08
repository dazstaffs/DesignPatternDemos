using DesignPatternDemos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Abstract
{
    public class AbstractDriverControls
    {
        private IEngine engine;

        public AbstractDriverControls(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IgnitionOn()
        {
            this.engine.Start();
        }

        public virtual void IgnitionOff()
        {
            this.engine.Stop();
        }

        public virtual void Accelerate()
        {
            this.engine.IncreasePower();
        }

        public virtual void Brake()
        {
            this.engine.DecreasePower();
        }
    }
}
