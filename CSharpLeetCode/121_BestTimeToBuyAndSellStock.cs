namespace CSharpLeetCode
{
    public class BestTimeToBuyAndSellStockSolution 
    {
        public int MaxProfit(int[] prices) 
        {
            var minPrice = int.MaxValue;
            var maxProfit = 0;
            foreach (var price in prices)
            {
                if (price < minPrice) minPrice = price;
                else if (price - minPrice > maxProfit) maxProfit = price - minPrice;
            }
            
            return maxProfit;
        }    
    }
}