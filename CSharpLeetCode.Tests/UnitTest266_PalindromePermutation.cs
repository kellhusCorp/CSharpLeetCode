using CSharpLeetCode;

namespace CSharpLeetCode.Tests
{
    [TestFixture]
    [TestOf(typeof(PalindromePermutationSolution))]
    public class UnitTest266_PalindromePermutation
    {

        [Test]
        [TestCase("code", false)]
        [TestCase("aab", true)]
        [TestCase("carerac", true)]
        [TestCase("aa", true)]
        [TestCase("aabb", true)]
        public void Test_PalindromePermutation_CanPermutePalindrome(string s, bool expected)
        {
            var solution = new PalindromePermutationSolution();
            var result = solution.CanPermutePalindrome(s);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}