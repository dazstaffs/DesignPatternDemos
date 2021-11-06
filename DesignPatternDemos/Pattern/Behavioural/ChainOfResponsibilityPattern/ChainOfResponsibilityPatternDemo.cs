using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Pattern.Behavioural.ChainOfResponsibilityPattern
{
    public class ChainOfResponsibilityPatternDemo
    {
        public static void StartChainOfResponsibilityDemo()
        {
            string email = "I need my car repaired.";
            AbstractEmailHandler.Handle(email);
        }
    }
}
