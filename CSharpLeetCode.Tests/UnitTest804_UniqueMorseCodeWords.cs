namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest804_UniqueMorseCodeWords
{
    [TestCase(new[]{"gin","zen","gig","msg"}, 2)]
    [TestCase(new[]{"a"}, 1)]
    public void Test_Solution_UniqueMorseRepresentations_Returns_2_When_Exists_2_Different_Transformations_In_Words(string[] words, int expected)
    {
        var solution = new UniqueMorseCodeWordsSolution();

        var uniqueMorseRepresentations = solution.UniqueMorseRepresentations(words);
        
        Assert.That(uniqueMorseRepresentations, Is.EqualTo(expected));
    }
}