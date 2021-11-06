using DesignPatternDemos.Abstract;
using System;

namespace DesignPatternDemos.Concrete.EmailHandler
{
    class GeneralEnquiriesEmailHandler : AbstractEmailHandler
    {
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Forward email to general enquiries.");
        }

        protected internal override string[] MatchingWords()
        {
            return new string[0]; //match anything
        }
    }
}
