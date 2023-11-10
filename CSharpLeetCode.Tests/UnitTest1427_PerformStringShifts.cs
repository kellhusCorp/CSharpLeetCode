namespace CSharpLeetCode.Tests
{
    public class UnitTest1427_PerformStringShifts
    {
        [Test]
        [TestCase("abc", 1, "bca")]
        public void Test_PerformStringShifts_LeftShift(string s, int amount, string expected)
        {
            var result = PerformStringShiftsSolution.LeftShift(s.ToCharArray(), amount);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("abc", 2, new[] {'b', 'c', 'a'})]
        [TestCase("bca", 2, new[] {'c', 'a', 'b'})]
        public void Test_PerformStringShifts_RightShift(string s, int amount, char[] expected)
        {
            var result = PerformStringShiftsSolution.RightShift(s.ToCharArray(), 2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_PerformStringShifts_StringShift_When_String_Equals_abc_Returns_cab()
        {
            var s = "abc";
            var shift = new[] { new[] { 0, 1 }, new[] { 1, 2 } };
            var sol = new PerformStringShiftsSolution();

            var result = sol.StringShift(s, shift);
            
            Assert.That(result, Is.EqualTo("cab"));
        }
        
        [Test]
        public void Test_PerformStringShifts_StringShift_When_String_Equals_abcdefg_Returns_efgabcd()
        {
            var s = "abcdefg";
            var shift = new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] {0,2}, new[] {1,3} };
            var sol = new PerformStringShiftsSolution();

            var result = sol.StringShift(s, shift);
            
            Assert.That(result, Is.EqualTo("efgabcd"));
        }
        
        [Test]
        public void Test_PerformStringShifts_StringShift_When_String_Equals_abc_Returns_bca()
        {
            var s = "abc";
            var shift = new[] { new[] {0,4}};
            var sol = new PerformStringShiftsSolution();

            var result = sol.StringShift(s, shift);
            
            Assert.That(result, Is.EqualTo("bca"));
        }
        
        [Test]
        public void Test_PerformStringShifts_StringShift_When_String_Equals_leetcode_Returns_deleetco()
        {
            var s = "leetcode";
            var shift = new[] { new[] {1, 10}};
            var sol = new PerformStringShiftsSolution();

            var result = sol.StringShift(s, shift);
            
            Assert.That(result, Is.EqualTo("deleetco"));
        }
    }
}