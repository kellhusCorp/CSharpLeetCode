namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest104_MaximumDepthOfBinaryTree
    {
        [Test]
        public void Test_MaximumDepthOfBinaryTreeSolution_MaxDepth_FirstCase()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var solution = new MaximumDepthOfBinaryTreeSolution();
            var result = solution.MaxDepth(root);
            Assert.That(result, Is.EqualTo(3));
        } 
        
        [Test]
        public void Test_MaximumDepthOfBinaryTreeSolution_MaxDepth_SecondCase()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            var solution = new MaximumDepthOfBinaryTreeSolution();
            var result = solution.MaxDepth(root);
            Assert.That(result, Is.EqualTo(3));
        }
        
        [Test]
        public void Test_MaximumDepthOfBinaryTreeSolution_MaxDepthIteratively_FirstCase()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var solution = new MaximumDepthOfBinaryTreeSolution();
            var result = solution.MaxDepthIteratively(root);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}