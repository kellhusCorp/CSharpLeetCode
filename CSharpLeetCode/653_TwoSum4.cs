namespace CSharpLeetCode;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class TwoSum4Solution
{
    private readonly HashSet<int> _set = new();

    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null) return false;
        if (_set.Contains(k - root.val))
            return true;
        _set.Add(root.val);
        return FindTarget(root.left, k) || FindTarget(root.right, k);
    }
}