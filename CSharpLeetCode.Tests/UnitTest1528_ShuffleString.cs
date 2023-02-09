namespace CSharpLeetCode.Tests;

public class UnitTest1528ShuffleString
{
    [Test]
    [TestCase("codeleet", new [] {4,5,6,7,0,2,1,3}, "leetcode")]
    public void Test_Solution(string s, int[] indices, string output)
    {
        var sol = new ShuffleStringSolution();

        var result = sol.RestoreString(s, indices);

        Assert.That(result, Is.EqualTo(output));
    }
}