namespace CSharpLeetCode.Tests
{
    public class UnitTest205_IsomorphicStrings
    {
        [Test]
        [TestCase("egg", "add", true)]
        [TestCase("foo", "bar", false)]
        [TestCase("paper", "title", true)]
        [TestCase("bbbaaaba", "aaabbbba", false)]
        public void Test_IsomorphicStringsSolution_IsIsomorphic_Returns_Expected(string s, string t, bool expected)
        {
            var sol = new IsomorphicStringsSolution();

            var result = sol.IsIsomorphic(s, t);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}