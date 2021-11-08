using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos.Pattern.Behavioural.ObserverPattern
{
    public class SpeedMonitor
    {
        public const int SpeedToAlert = 70;

        public SpeedMonitor(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            Speedometer speedo = (Speedometer)sender;
            if (speedo.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine($"**ALERT** Driving too fast ({speedo.CurrentSpeed})");
            }
            else
            {
                Console.WriteLine($"...nice and steady...({speedo.CurrentSpeed})");
            }
        }
    }
}
