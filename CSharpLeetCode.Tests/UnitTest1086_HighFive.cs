namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest1086_HighFive
    {
        [Test]
        public void Test_HighFiveSolution_HighFive_FirstCase()
        {
            int[][] items =
            {
                new[] { 1, 91 }, new[] { 1, 92 }, new[] { 2, 93 }, new[] { 2, 97 }, new[] { 1, 60 },
                new[] { 2, 77 }, new[] { 1, 65 }, new[] { 1, 87 }, new[] { 1, 100 }, new[] { 2, 100 },
                new[] { 2, 76 }
            };
            var sol = new HighFiveSolution();

            var result = sol.HighFive(items);

            Assert.That(result, Is.EquivalentTo(new[] { new[] { 1, 87 }, new[] { 2, 88 } }));
        }

        [Test]
        public void Test_HighFiveSolution_HighFive_SecondCase()
        {
            int[][] items =
            {
                new[] { 5, 91 }, new[] { 5, 92 }, new[] { 3, 93 }, new[] { 3, 97 }, new[] { 5, 60 },
                new[] { 3, 77 }, new[] { 5, 65 }, new[] { 5, 87 }, new[] { 5, 100 }, new[] { 3, 100 },
                new[] { 3, 76 }
            };
            var sol = new HighFiveSolution();

            var result = sol.HighFive(items);

            Assert.That(result, Is.EquivalentTo(new[] { new[] { 3, 88 }, new[] { 5, 87 } }));
        }
    }
}