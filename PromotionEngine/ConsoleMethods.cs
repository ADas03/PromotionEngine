using System;

namespace PromotionEngine
{
    class ConsoleMethods : IConsole
    {
        public void WriteLine(dynamic message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
