using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest938_RangeSumOfBST
{
    [Test]
    public void Test_RangeSumOfBSTSolution_RangeSumBST()
    {
        var root = GetFirstRootNode();
        int low = 7, high = 15;

        var result = new RangeSumOfBSTSolution().RangeSumBST(root, low, high);
        
        Assert.That(result, Is.EqualTo(32));
    }

    public static TreeNode GetFirstRootNode()
    {
        return new TreeNode(10,
            left: new TreeNode(5, new TreeNode(3), new TreeNode(7)),
            right: new TreeNode(15, null, new TreeNode(18)));
    }
}