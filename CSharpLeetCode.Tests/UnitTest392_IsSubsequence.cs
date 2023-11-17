namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest392_IsSubsequence
    {
        [Test]
        [TestCase("abc", "ahbgdc", true)]
        [TestCase("axc", "ahbgdc", false)]
        [TestCase("acb", "ahbgdc", false)]
        public void Test_IsSubsequenceSolution_IsSubsequence(string s, string t, bool expected)
        {
            var sol = new IsSubsequenceSolution();

            var result = sol.IsSubsequence(s, t);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}