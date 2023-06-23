namespace CSharpLeetCode;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 * public int val;
 * public TreeNode left;
 * public TreeNode right;
 * public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 * this.val = val;
 * this.left = left;
 * this.right = right;
 * }
 * }
 */
public class RangeSumOfBSTSolution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        var summator = 0;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Any())
        {
            var node = stack.Pop();
            if (node != null)
            {
                if (node.val <= high && node.val >= low) summator += node.val;
                if (node.val > low) stack.Push(node.left);
                if (node.val < high) stack.Push(node.right);
            }
        }

        return summator;
    }
}