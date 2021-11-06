using DesignPatternDemos.Abstract;
using System;

namespace DesignPatternDemos.Concrete.EmailHandler
{
    class ManagerEmailHandler : AbstractEmailHandler
    {
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("?Forwarding email to management team");
        }

        protected internal override string[] MatchingWords()
        {
            return new string[] { "complain", "bad", "unhappy" };
        }
    }
}
