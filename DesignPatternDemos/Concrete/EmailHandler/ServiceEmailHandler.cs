using DesignPatternDemos.Abstract;
using System;

namespace DesignPatternDemos.Concrete.EmailHandler
{
    class ServiceEmailHandler : AbstractEmailHandler
    {
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Forwarding to Service Department.");
        }

        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "repair" };
        }
    }
}
