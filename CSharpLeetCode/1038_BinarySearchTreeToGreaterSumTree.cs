namespace CSharpLeetCode
{
    public class BinarySearchTreeToGreaterSumTreeSolution
    {
        private int _sum = 0;
        
        public TreeNode BstToGst(TreeNode root)
        {
            var sum = 0;
            var currentNode = root;
            var stack = new Stack<TreeNode>();
            while (stack.Any() || currentNode != null)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.right;
                }

                currentNode = stack.Pop();
                sum += currentNode.val;
                currentNode.val = sum;

                currentNode = currentNode.left;
            }

            return root;
        }
        
        public TreeNode BstToGstRecursively(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            
            BstToGstRecursively(root.right);
            _sum += root.val;
            root.val = _sum;
            BstToGstRecursively(root.left);
            return root;
        }
    }
}