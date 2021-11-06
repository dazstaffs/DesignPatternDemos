using System;

namespace DesignPatternDemos.Pattern.Creational.Singleton
{
    public class SingletonPatternDemo
    {
        internal static void StartSingletonPatternDemo()
        {
            Console.WriteLine($"The next serial number is: {SerialNumberGenerator.Instance.NextSerial}");
            Console.WriteLine($"The next serial number is: {SerialNumberGenerator.Instance.NextSerial}");
            Console.WriteLine($"The next serial number is: {SerialNumberGenerator.Instance.NextSerial}");
        }
    }
}
