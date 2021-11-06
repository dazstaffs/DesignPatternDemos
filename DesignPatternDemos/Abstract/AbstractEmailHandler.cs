using DesignPatternDemos.Concrete.EmailHandler;
using DesignPatternDemos.Interface;

namespace DesignPatternDemos.Abstract
{
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        private IEmailHandler nextHandler;
        protected internal abstract string[] MatchingWords();
        protected internal abstract void HandleHere(string email);

        public virtual IEmailHandler NextHandler
        {
            set => nextHandler = value;
        }

        public void ProcessHandler(string email)
        {
            bool wordFound = false;

            if (MatchingWords().Length == 0)
            {
                wordFound = true;
            }
            else
            {
                foreach (string word in MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        wordFound = true;
                        break;
                    }
                }
            }
            if (wordFound)
            {
                HandleHere(email);
            }
            else
            {
                nextHandler.ProcessHandler(email);
            }
        }

        public static void Handle(string email)
        {
            IEmailHandler spam = new SpamEmailHandler();
            IEmailHandler sales = new SalesEmailHandler();
            IEmailHandler service = new ServiceEmailHandler();
            IEmailHandler manager = new ManagerEmailHandler();
            IEmailHandler general = new GeneralEnquiriesEmailHandler();

            //Create chain
            spam.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = manager;
            manager.NextHandler = general;

            //Start ball rolling
            spam.ProcessHandler(email);
        }
    }
}
