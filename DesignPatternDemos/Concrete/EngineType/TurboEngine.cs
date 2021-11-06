namespace DesignPatternDemos.Concrete.EngineType
{
    public class TurboEngine : Engine
    {
        public TurboEngine(int size, bool turbo) : base(size, turbo)
        {

        }

        public TurboEngine(int size) : base(size, true)
        {

        }
    }
}
