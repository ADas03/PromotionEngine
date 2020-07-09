namespace PromotionEngine.BusinessLogic
{
    public interface IProvider
    {
       int GetTotalPrice(int totalATypeProduct, int totalBTypeProduct, int totalCTypeProduct,
            int totalDTypeProduct);
    }
}
