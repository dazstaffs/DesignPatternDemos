using DesignPatternDemos.Abstract;
using System;

namespace DesignPatternDemos.Concrete.EmailHandler
{
    public class SpamEmailHandler : AbstractEmailHandler
    {
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is spam email");
        }

        protected internal override string[] MatchingWords()
        {
            return new string[] { "viagra", "pills", "medicines" };
        }
    }
}
