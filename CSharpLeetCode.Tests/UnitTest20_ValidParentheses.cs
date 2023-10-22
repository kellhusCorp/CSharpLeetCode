namespace CSharpLeetCode.Tests
{
    public class UnitTest20_ValidParentheses
    {
        [Test]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("]", false)]
        public void Test_ValidParenthesesSolution_IsValid(string s, bool isValid)
        {
            var sol = new ValidParenthesesSolution();

            var result = sol.IsValid(s);
            
            Assert.That(result, Is.EqualTo(isValid));
        }
    }
}