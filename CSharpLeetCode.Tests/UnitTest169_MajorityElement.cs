namespace CSharpLeetCode.Tests;

public class UnitTest169MajorityElement
{
    [Test]
    [TestCase(new int[] {3, 2, 3})]
    public void Test_First(int[] nums)
    {
        Assert.That(new MajorityElementSolution().MajorityElement(nums), Is.EqualTo(3));
    }
}