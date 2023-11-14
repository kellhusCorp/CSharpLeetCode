namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest125_ValidPalindrome
    {
        [Test]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        [TestCase(" ", true)]
        public void Test_ValidPalindrome_IsValid(string s, bool expected)
        {
            var result = new ValidPalindromeSolution().IsPalindrome(s);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}