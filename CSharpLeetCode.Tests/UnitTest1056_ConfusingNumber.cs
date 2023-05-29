using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest1056ConfusingNumber
{
    [Test]
    [TestCase(6, true)]
    [TestCase(89, true)]
    [TestCase(11, false)]
    [TestCase(8000, true)]
    public void Test_ConfusingNumber_Returns_ResultExpected_When_N_Equals_N(int n, bool expected)
    {
        var sol = new ConfusingNumberSolution();

        var result = sol.ConfusingNumber(n);
        
        Assert.That(result, expected ? Is.True : Is.False);
    }
}