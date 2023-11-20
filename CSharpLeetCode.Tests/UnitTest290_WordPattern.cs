namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest290_WordPattern
    {
        [Test]
        [TestCase("abba", "dog cat cat dog", true)]
        [TestCase("abba", "dog cat cat fish", false)]
        [TestCase("aaaa", "dog cat cat dog", false)]
        [TestCase("abba", "dog dog dog dog", false)]
        [TestCase("aaa", "aa aa aa aa", false)]
        public void Test_WordPatternSolution_WordPattern(string pattern, string s, bool expected)
        {
            var sol = new WordPatternSolution();

            var result = sol.WordPattern(pattern, s);
            
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [Test]
        [TestCase("abba", "dog cat cat dog", true)]
        [TestCase("abba", "dog cat cat fish", false)]
        [TestCase("aaaa", "dog cat cat dog", false)]
        [TestCase("abba", "dog dog dog dog", false)]
        [TestCase("aaa", "aa aa aa aa", false)]
        public void Test_WordPatternSolution_WordPatternAnotherOne(string pattern, string s, bool expected)
        {
            var sol = new WordPatternSolution();

            var result = sol.WordPattern(pattern, s);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}