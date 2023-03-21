using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTests1832_SentenseIsPangram
{
    
    [Test]
    public void Test_Sentence_Is_Pangram()
    {
        var sentence = "thequickbrownfoxjumpsoverthelazydog";

        var result = new SentenceIsPangramSolution().CheckIfPangram(sentence);
        
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void Test_Sentence_Is_Not_Pangram()
    {
        var sentence = "leetcode";

        var result = new SentenceIsPangramSolution().CheckIfPangram(sentence);
        
        Assert.That(result, Is.EqualTo(false));
    }
}