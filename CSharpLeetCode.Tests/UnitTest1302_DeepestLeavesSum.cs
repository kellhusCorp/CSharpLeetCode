using CSharpLeetCode.Deepest;

namespace CSharpLeetCode.Tests
{
    public static class TreeNodeFactory
    {
        public enum Variant
        {
            First,
            Second,
            Third,
            Fourth
        }

        public static Deepest.TreeNode Create(Variant variant)
        {
            switch (variant)
            {
                case Variant.First:
                    return new Deepest.TreeNode(1, new Deepest.TreeNode(2, new Deepest.TreeNode(4, new Deepest.TreeNode(7)), new Deepest.TreeNode(5)),
                        new Deepest.TreeNode(3, null, new Deepest.TreeNode(6, null, new Deepest.TreeNode(8))));
                case Variant.Second:
                    return new Deepest.TreeNode(6, new Deepest.TreeNode(7, new Deepest.TreeNode(2, new Deepest.TreeNode(9)), new Deepest.TreeNode(7, new Deepest.TreeNode(1), new Deepest.TreeNode(4))),
                        new Deepest.TreeNode(8, new Deepest.TreeNode(1), new Deepest.TreeNode(3, null, new Deepest.TreeNode(5))));
                case Variant.Third:
                    return new Deepest.TreeNode(1);
                case Variant.Fourth:
                    return new Deepest.TreeNode(0, null, new Deepest.TreeNode(1));
                default:
                    throw new ArgumentOutOfRangeException(nameof(variant), variant, null);
            }
        }
    }
    
    [TestFixture]
    public class UnitTest1302DeepestLeavesSum
    {
        [Test]
        [TestCase(TreeNodeFactory.Variant.First, 15)]
        [TestCase(TreeNodeFactory.Variant.Second, 19)]
        [TestCase(TreeNodeFactory.Variant.Third, 1)]
        [TestCase(TreeNodeFactory.Variant.Fourth, 1)]
        public void Test_DeepestLeavesSumSolution_DeepestLeavesSum_When_Root_Equals_Variant(TreeNodeFactory.Variant variant, int expected)
        {
            var root = TreeNodeFactory.Create(variant);

            var result = new DeepestLeavesSumSolution().DeepestLeavesSum(root);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}