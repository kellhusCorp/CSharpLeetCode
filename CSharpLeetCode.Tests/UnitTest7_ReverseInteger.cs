namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest7_ReverseInteger
    {
        [Test]
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(int.MaxValue, 0)]
        public void Test_ReverseInteger_Reverse(int input, int expected)
        {
            var sol = new ReverseIntegerSolution();

            var result = sol.Reverse(input);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}