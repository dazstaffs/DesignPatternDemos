using DesignPatternDemos.Abstract;
using System;

namespace DesignPatternDemos.Concrete.EmailHandler
{
    public class SalesEmailHandler : AbstractEmailHandler
    {
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Forwarding to Sales department.");
        }

        protected internal override string[] MatchingWords()
        {
            return new string[] { "buy", "purchase" };
        }
    }
}
