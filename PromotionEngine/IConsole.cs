using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    // For unit test I need to mock console readline and 
    // writeline thats why keeping it in an inteface.
    public interface IConsole
    {
        void WriteLine(dynamic message);
        string ReadLine();
    }
}
