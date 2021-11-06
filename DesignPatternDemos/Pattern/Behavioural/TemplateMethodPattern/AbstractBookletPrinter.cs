namespace DesignPatternDemos.Pattern.Behavioural.TemplatePattern
{
    public abstract class AbstractBookletPrinter
    {
        protected internal abstract int PageCount { get; }
        protected internal abstract void PrintFrontCover();
        protected internal abstract void PrintTableOfContents();
        protected internal abstract void PrintPage(int pageNumber);
        protected internal abstract void PrintIndex();
        protected internal abstract void PrintBackCover();

        public void Print()
        {
            PrintFrontCover();
            PrintTableOfContents();
            for (int i = 0; i < PageCount; i++)
            {
                PrintPage(i);
            }
            PrintIndex();
            PrintBackCover();
        }
    }
}
