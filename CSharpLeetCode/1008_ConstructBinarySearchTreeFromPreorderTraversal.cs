namespace CSharpLeetCode
{
    public class ConstructBinarySearchTreeFromPreorderTraversalSolution
    {
        private int _i = 0;
        private int[] _preorder;
        private int n;
        public TreeNode BstFromPreorderRecursively(int[] preorder)
        {
            _preorder = preorder;
            _i = 0;
            n = preorder.Length;
            return Traverse(int.MinValue, int.MaxValue);
        }

        public TreeNode BstFromPreorderIteratively(int[] preorder)
        {
            if (preorder.Length == 0) return null;

            var root = new TreeNode(preorder[0]);
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            for (int i = 1; i < preorder.Length; i++)
            {
                var node = stack.Peek();
                var child = new TreeNode(preorder[i]);
                while (stack.Any() && stack.Peek().val < child.val)
                {
                    node = stack.Pop();
                }

                if (node.val < child.val)
                {
                    node.right = child;
                }
                else
                {
                    node.left = child;
                }
                
                stack.Push(child);
            }

            return root;
        }

        private TreeNode Traverse(int low, int high)
        {
            if (_i == n) return null;

            var val = _preorder[_i];
            if (IsOutOfRange(val, low, high)) return null;

            _i++;
            var node = new TreeNode(val);
            node.left = Traverse(low, val);
            node.right = Traverse(val, high);
            return node;
        }

        private bool IsOutOfRange(int val, int low, int high) => val < low || val > high;
    }
}