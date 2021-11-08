using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternDemos.Pattern.Behavioural.ObserverPattern
{
    public class ObserverPatternDemo
    {
        public static void StartObserverPatternDemo()
        {
            Speedometer speedo = new Speedometer();
            SpeedMonitor speedMonitor = new SpeedMonitor(speedo);

            speedo.CurrentSpeed = 50;
            Thread.Sleep(2000);

            speedo.CurrentSpeed = 70;
            Thread.Sleep(2000);

            speedo.CurrentSpeed = 40;
            Thread.Sleep(2000);

            speedo.CurrentSpeed = 100;
            Thread.Sleep(2000);

            speedo.CurrentSpeed = 69;
            Thread.Sleep(2000);

            speedo.CurrentSpeed = 71;
        }
    }
}
