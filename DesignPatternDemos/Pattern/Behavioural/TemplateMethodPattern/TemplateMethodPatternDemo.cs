using System;

namespace DesignPatternDemos.Pattern.Behavioural.TemplatePattern
{
    class TemplateMethodPatternDemo
    {
        internal static void StartTemplateMethodPatternDemo()
        {
            Console.WriteLine("About to print a booklet for Saloon cars");
            AbstractBookletPrinter saloonBooklet = new SaloonBooklet();
            saloonBooklet.Print();

            Console.WriteLine("About to print a service history booklet");
            AbstractBookletPrinter serviceBooklet = new ServiceHistoryBooklet();
            serviceBooklet.Print();
        }
    }
}
