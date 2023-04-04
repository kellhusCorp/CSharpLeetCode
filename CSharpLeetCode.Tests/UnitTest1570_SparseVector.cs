using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest1570SparseVector
{
    [Test]
    [TestCase(new [] {1,0,0,2,3}, new[] {0,3,0,4,0}, 8)]
    [TestCase(new [] {0,1,0,0,0}, new[] {0,0,0,0,2}, 0)]
    [TestCase(new [] {0,1,0,0,2,0,0}, new[] {1,0,0,0,3,0,4}, 6)]
    public void Test(int[] firstNums, int[] secondNums, int expectedResult)
    {
        var firstVector = new SparseVector(firstNums);
        var secondVector = new SparseVector(secondNums);

        var result = firstVector.DotProduct(secondVector);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}