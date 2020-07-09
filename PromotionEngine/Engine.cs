using System;
using PromotionEngine.BusinessLogic;

namespace PromotionEngine
{
    public class Engine
    {
        private IProvider _provider;
        private IConsole _console;

        public Engine(IProvider provider, IConsole console)
        {
            _provider = provider;
            _console = console;
        }

        // Taking input from user
        public void MainApplication()
        {
            _console.WriteLine("Our Active Promotion: \n3 of A's for 130 \n2 of B's for 45 \nC & D for 30");
            _console.WriteLine("Start your order:");
            _console.WriteLine("Enter total no of A type product");
            int totalAProducts = Convert.ToInt32(_console.ReadLine());
            _console.WriteLine("Enter total no of B type product");
            int totalBProducts = Convert.ToInt32(_console.ReadLine());
            _console.WriteLine("Enter total no of C type product");
            int totalCProducts = Convert.ToInt32(_console.ReadLine());
            _console.WriteLine("Enter total no of D type product");
            int totalDProducts = Convert.ToInt32(_console.ReadLine());
            int totalPrice = _provider.GetTotalPrice(totalAProducts, totalBProducts, totalCProducts, totalDProducts);
            _console.WriteLine(totalPrice);
            _console.WriteLine("Want to order again ? Press (Y/y) to continue else press any button and enter.");
            string answer = _console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                MainApplication();
            }
            else
            {
                return;
            }
        }
    }
}
