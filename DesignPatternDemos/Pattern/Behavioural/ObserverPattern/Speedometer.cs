using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Behavioural.ObserverPattern
{
    public class Speedometer
    {
        public event EventHandler ValueChanged;
        private int currentSpeed;

        public Speedometer()
        {
            this.currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                currentSpeed = value;
                OnValueChanged();
            }

            get => currentSpeed;

        }

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }
    }
}
