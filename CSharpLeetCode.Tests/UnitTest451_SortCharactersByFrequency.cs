namespace CSharpLeetCode.Tests
{
    public class UnitTest451SortCharactersByFrequency
    {
        [Test]
        [TestCase("tree", "eetr")]
        [TestCase("cccaaa", "cccaaa")]
        [TestCase("Aabb", "bbAa")]
        public void Test_SortCharactersByFrequencySolution_FrequencySort(string input, string expected)
        {
            var sol = new SortCharactersByFrequencySolution();

            var result = sol.FrequencySort(input);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}