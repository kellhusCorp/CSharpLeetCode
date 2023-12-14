namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest100_SameTree
    {
        [Test]
        public void Test_SameTreeSolution_IsSameTree_FirstCase()
        {
            var p = new TreeNode(1);
            p.left = new TreeNode(2);
            p.right = new TreeNode(3);
            var q = new TreeNode(1);
            q.left = new TreeNode(2);
            q.right = new TreeNode(3);
            var expected = true;
            var solution = new SameTreeSolution();
            
            var actual = solution.IsSameTree(p, q);
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Test_SameTreeSolution_IsSameTree_SecondCase()
        {
            var p = new TreeNode(1);
            p.left = new TreeNode(2);
            var q = new TreeNode(1);
            q.right = new TreeNode(2);
            var expected = false;
            var solution = new SameTreeSolution();
            
            var actual = solution.IsSameTree(p, q);
            
            Assert.AreEqual(expected, actual);
        }
    }
}