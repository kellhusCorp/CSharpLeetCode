namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest88MergeSortedArray
{
    [Test]
    [TestCase(new int[] {1,2,3,0,0,0}, 3, new int[] {2,5,6}, 3, new int[] {1,2,2,3,5,6})]
    [TestCase(new int[] {1}, 1, new int[] {}, 0, new int[] {1})]
    [TestCase(new int[] {0}, 0, new int[] {1}, 1, new int[] {1})]
    public void Test_MergeSortedArray_Merge(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        var sol = new MergeSortedArraySolution();
        
        sol.Merge(nums1, m, nums2, n);
        
        Assert.That(nums1, Is.EquivalentTo(expected));
    }
}