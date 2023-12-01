namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest1038_BinarySearchTreeToGreaterSumTree
    {
        private TreeNode _firstTree;
        private TreeNode _secondTree;
        
        [SetUp]
        public void Init()
        {
            _firstTree = new TreeNode(4, new TreeNode(1, new TreeNode(0), new TreeNode(2, null, new TreeNode(3))),
                new TreeNode(6, new TreeNode(5), new TreeNode(7, null, new TreeNode(8))));
            _secondTree = new TreeNode(0, null, new TreeNode(1));
        }
        
        [Test]
        public void Test_BinarySearchTreeToGreaterSumTree_FirstCase()
        {
            BinarySearchTreeToGreaterSumTreeSolution solution = new BinarySearchTreeToGreaterSumTreeSolution();

            TreeNode result = solution.BstToGst(_firstTree);

            Assert.That(result.val, Is.EqualTo(30));
        }
        
        [Test]
        public void Test_BinarySearchTreeToGreaterSumTree_SecondCase()
        {
            var solution = new BinarySearchTreeToGreaterSumTreeSolution();
            
            var result = solution.BstToGst(_secondTree);
            
            Assert.That(result.val, Is.EqualTo(1));
        }

        [Test]
        public void Test_BinarySearchTreeToGreaterSumTree_Recursively()
        {
            var solution = new BinarySearchTreeToGreaterSumTreeSolution();
            
            var result = solution.BstToGstRecursively(_firstTree);
            
            Assert.That(result.val, Is.EqualTo(30));
        }
    }
}