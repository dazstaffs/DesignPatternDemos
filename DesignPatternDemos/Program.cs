using DesignPatternDemos.Pattern.Behavioural.ChainOfResponsibilityPattern;
using DesignPatternDemos.Pattern.Behavioural.ObserverPattern;
using DesignPatternDemos.Pattern.Behavioural.StrategyPattern;
using DesignPatternDemos.Pattern.Behavioural.TemplatePattern;
using DesignPatternDemos.Pattern.Behavioural.VisitorPattern;
using DesignPatternDemos.Pattern.Creational.BuilderPattern;
using DesignPatternDemos.Pattern.Creational.FactoryMethodPattern;
using DesignPatternDemos.Pattern.Creational.Singleton;
using DesignPatternDemos.Pattern.Structural.AdapterPattern;
using DesignPatternDemos.Pattern.Structural.BridgePattern;
using DesignPatternDemos.Pattern.Structural.DecoratorPattern;
using DesignPatternDemos.Pattern.Structural.StructuralPattern;
using System;

namespace DesignPatternDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryPatternMethodDemo.StartFactroyMethodPatternDemo();
            //AdapterPatternDemo.StartAdapterPatternDemo();
            //SingletonPatternDemo.StartSingletonPatternDemo();
            //StrategyPatternDemo.StartStrategyPatternDemo();
            //TemplateMethodPatternDemo.StartTemplateMethodPatternDemo();
            //BuilderPatternDemo.StartBuilderPatternDemo();
            //FacadePatternDemo.StartFacadePatternDemo();
            //VisitorPatternDemo.StartVisitorPatternDemo();
            //ChainOfResponsibilityPatternDemo.StartChainOfResponsibilityDemo();
            //DecoratorPatternDemo.StartDecoratorPatternDemo();
            //ObserverPatternDemo.StartObserverPatternDemo();
            BridgePatternDemo.StartBridgePatternDemo();
            Console.Read();
        }
    }
}
