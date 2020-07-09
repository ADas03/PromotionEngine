namespace PromotionEngine.BusinessLogic
{
    public class Provider : IProvider
    {
        public int GetTotalPrice(int totalATypeProduct, int totalBTypeProduct, int totalCTypeProduct, int totalDTypeProduct)
        {
            int totalPriceofA = (totalATypeProduct / 3) * 130 + (totalATypeProduct % 3 * Price.PriceOfA);
            int totalPriceofB = (totalBTypeProduct / 2) * 45 + (totalBTypeProduct % 2 * Price.PriceOfB);
            int totalPriceofC = 0;
            int totalPriceofD = 0;
            if (totalCTypeProduct == totalDTypeProduct && totalCTypeProduct > 0 && totalDTypeProduct > 0)
            {

                for (int i = 0; i < totalCTypeProduct; i++)
                {
                    totalPriceofD += 30;
                }

            }
            else if (totalCTypeProduct > totalDTypeProduct && totalCTypeProduct > 0 && totalDTypeProduct > 0)
            {
                int count = 0;
                for (int i = 0; i < totalDTypeProduct; i++)
                {
                    totalPriceofD += 30;
                    count++;
                }

                while (count < totalCTypeProduct)
                {
                    totalPriceofC += Price.PriceOfC;
                    count++;
                }

            }
            else if (totalCTypeProduct < totalDTypeProduct && totalCTypeProduct > 0 && totalDTypeProduct > 0)
            {
                int count = 0;
                for (int i = 0; i < totalCTypeProduct; i++)
                {
                    totalPriceofD += 30;
                    count++;
                }

                while (count < totalDTypeProduct)
                {
                    totalPriceofD += Price.PriceOfD;
                    count++;
                }

            }
            else
            {
                totalPriceofC = (totalCTypeProduct * Price.PriceOfC);
                totalPriceofD = (totalDTypeProduct * Price.PriceOfD);
            }
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
        }
    }
}
