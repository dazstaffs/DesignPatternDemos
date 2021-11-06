namespace DesignPatternDemos.Concrete.EngineType
{
    public class StandardEngine : Engine
    {

        public StandardEngine(int size, bool turbo) : base(size, turbo)
        {
        }

        public StandardEngine(int size) : base(size, false)
        {
        }
    }
}
