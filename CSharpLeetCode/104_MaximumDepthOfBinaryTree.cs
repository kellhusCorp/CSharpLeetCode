namespace CSharpLeetCode
{
    public class MaximumDepthOfBinaryTreeSolution
    {
        // Good = O(n) time complexity, O(n) space complexity
        // Bad = O(n) time complexity, O(n) space complexity
        // Average = O(n) time complexity, O(n) space complexity
        
        public int MaxDepth(TreeNode root) 
        {
            if(root == null)
                return 0;
            
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            
            return leftDepth > rightDepth ? leftDepth + 1 : rightDepth + 1;
        }

        public int MaxDepthIteratively(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var depth = 0;
            while (queue.Any())
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                depth++;
            }

            return depth;
        }
    }
}