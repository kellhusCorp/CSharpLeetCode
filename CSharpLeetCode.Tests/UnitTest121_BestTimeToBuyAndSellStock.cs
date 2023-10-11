namespace CSharpLeetCode.Tests
{
    public class UnitTest121_BestTimeToBuyAndSellStock
    {
        [Test]
        [TestCase(new[] {7, 1, 5, 3, 6, 4}, 5)]
        [TestCase(new[] {7, 6, 4, 3, 1}, 0)]
        [TestCase(new[] {2, 4, 1}, 2)]
        [TestCase(new[] {2, 1, 2, 1, 0, 1, 2}, 2)]
        [TestCase(new[] {2, 1, 2, 1, 0, 1, 2, 1, 2}, 2)]
        public void TestMethod1(int[] prices, int expected)
        {
            var solution = new BestTimeToBuyAndSellStockSolution();
            
            int maxProfit = solution.MaxProfit(prices);
            
            Assert.That(maxProfit, Is.EqualTo(expected));
        }
    }
}