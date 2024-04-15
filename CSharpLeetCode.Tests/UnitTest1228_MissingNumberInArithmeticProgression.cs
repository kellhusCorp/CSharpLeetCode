namespace CSharpLeetCode.Tests
{
    [TestFixture]
    [TestOf(typeof(MissingNumberInArithmeticProgressionSolution))]
    public class UnitTest1228_MissingNumberInArithmeticProgression
    {
        [Test]
        public void Test_MissingNumberInArithmeticProgressionSolution_FirstCase()
        {
            var arr = new[] {5, 7, 11, 13};
            var solution = new MissingNumberInArithmeticProgressionSolution();
            
            var result = solution.MissingNumberLinearSearch(arr);
            
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Test_MissingNumberInArithmeticProgressionSolution_TwentySixthCase()
        {
            var arr = new[] { 1, 2, 3, 5 };
            var solution = new MissingNumberInArithmeticProgressionSolution();
            
            var result = solution.MissingNumberLinearSearch(arr);
            
            Assert.That(result, Is.EqualTo(4));
        }
    }
}