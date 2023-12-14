namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest219_ContainsDuplicateII
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 1}, 3, true)]
        [TestCase(new int[] {1, 0, 1, 1}, 1, true)]
        [TestCase(new int[] {1, 2, 3, 1, 2, 3}, 2, false)]
        public void Test_SecondContainsDuplicate_ContainsNearbyDuplicate(int[] array, int k, bool expected)
        {
            var solution = new SecondContainsDuplicateSolution();
            
            var actual = solution.ContainsNearbyDuplicate(array, k);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}