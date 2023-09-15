namespace CSharpLeetCode.Deepest
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public static class TreeNodeExtensions
    {
        public static bool IsExistChildren(this TreeNode node)
        {
            return node.left != null || node.right != null;
        }
    }
    
    public class DeepestLeavesSumSolution
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            int sum = 0, depth = 0, currentDepth;
            
            var stack = new Stack<(TreeNode Node, int Depth)>();
            
            stack.Push((root, 0));

            while (stack.Any())
            {
                var pair = stack.Pop();

                var node = pair.Node;

                currentDepth = pair.Depth;
                
                if (!node.IsExistChildren())
                {
                    if (depth < currentDepth)
                    {
                        sum = node.val;
                        depth = currentDepth;
                    }
                    else if (depth == currentDepth)
                    {
                        sum += node.val;
                    }
                }

                else
                {
                    PushChildren(node, stack, currentDepth);
                }
            }

            return sum;
        }

        private static void PushChildren(TreeNode node, Stack<(TreeNode Node, int Depth)> stack, int currentDepth)
        {
            if (node.left != null)
            {
                stack.Push((node.left, currentDepth + 1));
            }

            if (node.right != null)
            {
                stack.Push((node.right, currentDepth + 1));
            }
        }
    }
}