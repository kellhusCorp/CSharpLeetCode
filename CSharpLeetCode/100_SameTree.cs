namespace CSharpLeetCode
{
    public class SameTreeSolution
    {
        public bool IsSameTree(TreeNode p, TreeNode q) 
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }
            
            if (p.val != q.val)
            {
                return false;
            }

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right) && p.val == q.val;
        }
    }
}