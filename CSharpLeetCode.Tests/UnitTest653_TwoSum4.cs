namespace CSharpLeetCode.Tests;

public class UnitTest653TwoSum4
{
    private TwoSum4Solution _solution;
    
    [SetUp]
    public void Setup()
    {
        _solution = new TwoSum4Solution();
    }

    [Test]
    public void Test1()
    {
        var rootNode = GetBst();

        var result = _solution.FindTarget(rootNode, 9);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test2()
    {
        var rootNode = GetBst();

        var result = _solution.FindTarget(rootNode, 28);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test3()
    {
        var rootNode = new TreeNode
        {
            val = 2,
            left = new TreeNode(1, null, null),
            right = new TreeNode(3, null, null)
        };

        var result = _solution.FindTarget(rootNode, 3);
        
        Assert.That(result, Is.True);
    }

    private TreeNode GetBst()
    {
        return new TreeNode
        {
            val = 5,
            left = new TreeNode
            {
                val = 3,
                left = new TreeNode(2, null, null),
                right = new TreeNode(4, null, null)
            },
            right = new TreeNode
            {
                val = 6,
                left = new TreeNode(7, null, null)
            }
        };
    }
}