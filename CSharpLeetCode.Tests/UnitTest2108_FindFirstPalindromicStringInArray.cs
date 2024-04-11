namespace CSharpLeetCode.Tests
{
    public class UnitTest2108_FindFirstPalindromicStringInArray
    {
        [Test]
        public void Test_FindFirstPalindromicStringInArraySolution_FirstPalindrome_FirstCase()
        {
            var words = new string[] {"abc","car","ada","racecar","cool"};
            var sol = new FindFirstPalindromicStringInArraySolution();
            
            var result = sol.FirstPalindrome(words);
            
            Assert.That(result, Is.EqualTo(words[2]));
        }
        
        [Test]
        public void Test_FindFirstPalindromicStringInArraySolution_FirstPalindrome_SecondCase()
        {
            var words = new string[] {"notapalindrome", "racecar"};
            var sol = new FindFirstPalindromicStringInArraySolution();

            var result = sol.FirstPalindrome(words);
            
            Assert.That(result, Is.EqualTo(words[1]));
        }
        
        [Test]
        public void Test_FindFirstPalindromicStringInArraySolution_FirstPalindrome_ThirdCase()
        {
            var words = new string[] {"def","ghi"};
            var sol = new FindFirstPalindromicStringInArraySolution();

            var result = sol.FirstPalindrome(words);
            
            Assert.That(result, Is.EqualTo(string.Empty));
        }
        
        [Test]
        public void Test_FindFirstPalindromicStringInArraySolution_FirstPalindrome_OneHundredEightiethCase()
        {
            var words = new string[] {"po","zsz"};
            var sol = new FindFirstPalindromicStringInArraySolution();

            var result = sol.FirstPalindrome(words);
            
            Assert.That(result, Is.EqualTo(words[1]));
        }

    }
}