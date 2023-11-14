namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest14_LongestCommonPrefix
    {
        [Test]
        [TestCase(new[] {"flower", "flow", "flight"}, "fl")]
        [TestCase(new[] {"dog", "racecar", "car"}, "")]
        [TestCase(new[] {"c", "acc", "ccc"}, "")]
        public void Test_LongestCommonPrefix_LongestCommonPrefix(string[] strs, string expected)
        {
            var result = new LongestCommonPrefixSolution().LongestCommonPrefix(strs);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}