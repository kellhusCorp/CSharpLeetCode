using NUnit.Framework;

namespace CSharpLeetCode.Tests;

public class UnitTest2574_LeftAndRightSumDifference
{
    [Test]
    [TestCase(new int[]{10,4,8,3}, new int[] {15,1,11,22})]
    [TestCase(new int[]{1}, new int[] {0})]
    public void Test_LeftAndRightSumDifference_LeftRightDifference(int[] nums, int[] expected)
    {
        var sol = new LeftAndRightSumDifferenceSolution();

        var result = sol.LeftRightDifference(nums);
        
        Assert.That(result, Is.EquivalentTo(expected));
    }
}