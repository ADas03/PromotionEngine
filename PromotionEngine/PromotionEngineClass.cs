using PromotionEngine.BusinessLogic;

namespace PromotionEngine
{
    public class PromotionEngineClass
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine(new Provider(), new ConsoleMethods());
            engine.MainApplication();
        }
      
    }
}
