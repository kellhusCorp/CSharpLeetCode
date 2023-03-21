namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest2006_CountNumberOfPairs
{
    [TestCase(new int[] {1,2,2,1}, 1, 4)]
    [TestCase(new int[] {1,3}, 3, 0)]
    [TestCase(new int[] {3,2,1,5,4}, 2, 3)]
    public void Test_Solution_CountKDifference_Returns_4_When_There_Is_4_Pairs(int[] nums, int k, int expected)
    {
        var solution = new CountNumberOfPairsSolution();

        var pairs = solution.CountKDifference(nums, k);
        
        Assert.That(pairs, Is.EqualTo(expected));
    }
}