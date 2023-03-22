using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest1684_CountNumbersOfConsistentStrings
{
    [TestCase("ab", new [] {"ad","bd","aaab","baa","badab"}, 2)]
    [TestCase("abc", new [] {"a","b","c","ab","ac","bc","abc"}, 7)]
    [TestCase("cad", new [] {"cc","acd","b","ba","bac","bad","ac","d"}, 4)]
    public void Test_Solution_CountConsistentStrings_Returns_2(string allowed, string[] words, int expected)
    {
        var sol = new CountNumberOfConsistentStringSolution();

        var result = sol.CountConsistentStrings(allowed, words);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}