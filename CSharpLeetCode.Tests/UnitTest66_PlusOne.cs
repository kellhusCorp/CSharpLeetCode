namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest66_PlusOne
    {
        [Test]
        [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
        [TestCase(
            new int[]
            {
                7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1,
                1, 7, 4, 0, 0, 6
            },
            new int[]
            {
                7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1,
                1, 7, 4, 0, 0, 7
            })]
        public void Test_PlusOne_PLusOne(int[] digits, int[] expected)
        {
            var solution = new PlusOneSoltuion();
            var actual = solution.PlusOne(digits);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}