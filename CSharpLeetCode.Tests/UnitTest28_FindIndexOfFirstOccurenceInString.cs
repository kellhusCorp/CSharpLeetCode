namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest28_FindIndexOfFirstOccurenceInString
    {
        [Test]
        [TestCase("sadbutsad", "sad", 0)]
        [TestCase("leetcode", "leeto", -1)]
        [TestCase("youneedtobestrong", "tobe", 7)]
        [TestCase("ttpppttttzzzzzreprp", "tttt", 5)]
        [TestCase("notfound", "notfound", 0)]
        public void Test_FindIndexOfFirstOccurenceInStringSolution_StrStr_Returns_Expected(string haystack,
            string needle, int expected)
        {
            var result = new FindIndexOfFirstOccurenceInStringSolution().StrStr(haystack, needle);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}