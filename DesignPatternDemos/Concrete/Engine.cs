using DesignPatternDemos.Abstract;

namespace DesignPatternDemos.Concrete
{
    public class Engine : AbstractEngine
    {
        public Engine(int size, bool turbo) : base(size, turbo)
        {

        }
    }
}
