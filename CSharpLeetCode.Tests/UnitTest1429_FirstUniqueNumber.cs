namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest1429_FirstUniqueNumber
    {
        [Test]
        public void Test_FirstUniqueNumberSolution_FirstCase()
        {
            var firstUniqueSol = new FirstUniqueNumberSolution(new int[]{2,3,5});
            Assert.That(firstUniqueSol.ShowFirstUnique(), Is.EqualTo(2));
            firstUniqueSol.Add(5);
            Assert.That(firstUniqueSol.ShowFirstUnique(), Is.EqualTo(2));
            firstUniqueSol.Add(2);
            Assert.That(firstUniqueSol.ShowFirstUnique(), Is.EqualTo(3));
            firstUniqueSol.Add(3);
            Assert.That(firstUniqueSol.ShowFirstUnique(), Is.EqualTo(-1));
        }

        [Test]
        public void Test_FirstUniqueNumberSolution_SecondCase()
        {
            var sol = new FirstUniqueNumberSolution(new int[] { 7, 7, 7, 7, 7, 7 });
            Assert.That(sol.ShowFirstUnique(), Is.EqualTo(-1));
            sol.Add(7);
            sol.Add(3);
            sol.Add(3);
            sol.Add(7);
            sol.Add(17);
            Assert.That(sol.ShowFirstUnique(), Is.EqualTo(17));
        }
    }
}