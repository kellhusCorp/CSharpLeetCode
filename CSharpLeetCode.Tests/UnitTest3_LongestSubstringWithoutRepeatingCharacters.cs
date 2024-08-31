namespace CSharpLeetCode.Tests
{
    public class UnitTest3_LongestSubstringWithoutRepeatingCharacters
    {
        [Test]
        [TestCase("abc", 3)]
        [TestCase("abcd", 4)]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void Test_LongestSubstringWithoutRepeatingCharactersSolution_FirstCase(string s, int expected)
        {
            var sol = new LongestSubstringWithoutRepeatingCharactersSolution();

            var maxLength = sol.LengthOfLongestSubstring(s);
            
            Assert.That(maxLength, Is.EqualTo(expected));
        }
    }
}