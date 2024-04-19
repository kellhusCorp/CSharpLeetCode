namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest2396_StrictlyPalindromicNumber
    {
        [Test]
        [TestCase(9, 3, "100")]
        [TestCase(50, 2, "110010")]
        [TestCase(45, 8, "55")]
        [TestCase(1450, 16, "5AA")]
        public void Test_StrictlyPalindromicNumberSolution_MoveToBase(int n, int @base, string expectedStr)
        {
            var sol = new StrictlyPalindromicNumberSolution();

            var result = sol.MoveToBase(n, @base);
            
            Assert.That(result, Is.EqualTo(expectedStr));
        }
        
        [Test]
        [TestCase(9, false)]
        [TestCase(4, false)]
        public void Test_StrictlyPalindromicNumberSolution_IsStrictlyPalindromic(int n, bool expected)
        {
            var sol = new StrictlyPalindromicNumberSolution();

            var result = sol.IsStrictlyPalindromic(n);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}