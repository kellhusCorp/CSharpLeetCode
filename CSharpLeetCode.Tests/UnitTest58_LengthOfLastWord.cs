namespace CSharpLeetCode.Tests
{
    public class UnitTest58_LengthOfLastWord
    {
        [Test]
        [TestCase("Hello World", 5)]
        [TestCase(" ", 0)]
        [TestCase("a ", 1)]
        [TestCase("a", 1)]
        [TestCase("a b", 1)]
        [TestCase("   fly me   to   the moon  ", 4)]
        public void Test_LengthOfLastWordSolution_LengthOfLastWord_ReturnsCorrectLength(string s, int expected)
        {
            var actual = new LengthOfLastWordSolution().LengthOfLastWord(s);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}