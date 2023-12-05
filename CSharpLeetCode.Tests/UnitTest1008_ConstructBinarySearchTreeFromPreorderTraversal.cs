namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest1008_ConstructBinarySearchTreeFromPreorderTraversal
    {
        [Test]
        public void Test_ConstructBinarySearchTreeFromPreorderTraversal_BstFromPreorder()
        {
            var solution = new ConstructBinarySearchTreeFromPreorderTraversalSolution();
            
            var result = solution.BstFromPreorderRecursively(new[] {8, 5, 1, 7, 10, 12});
            
            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(8));

                Assert.That(result.left.val, Is.EqualTo(5));

                Assert.That(result.left.left.val, Is.EqualTo(1));

                Assert.That(result.left.right.val, Is.EqualTo(7));
            });
        }
        
        [Test]
        public void Test_ConstructBinarySearchTreeFromPreorderTraversal_BstFromPreorderIteratively_Firstcase()
        {
            var solution = new ConstructBinarySearchTreeFromPreorderTraversalSolution();
            
            var result = solution.BstFromPreorderIteratively(new[] {8, 5, 1, 7, 10, 12});
            
            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(8));

                Assert.That(result.left.val, Is.EqualTo(5));

                Assert.That(result.left.left.val, Is.EqualTo(1));

                Assert.That(result.left.right.val, Is.EqualTo(7));
            });
        }
        
        [Test]
        public void Test_ConstructBinarySearchTreeFromPreorderTraversal_BstFromPreorderIteratively_Secondcase()
        {
            var solution = new ConstructBinarySearchTreeFromPreorderTraversalSolution();
            
            var result = solution.BstFromPreorderIteratively(new[] {4, 2});
            
            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(4));

                Assert.That(result.left.val, Is.EqualTo(2));
            });
        }
    }
}