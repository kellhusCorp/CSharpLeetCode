namespace CSharpLeetCode.Tests
{
    public class UnitTest439_TernaryExpressionParser
    {
        [Test]
        [TestCase("T?2:3", "2")]
        [TestCase("F?1:T?4:5", "4")]
        [TestCase("T?T?F:5:3", "F")]
        public void Test_FirstCase(string expression, string expected)
        {
            var result = new TernaryExpressionParser().ParseTernary(expression);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}