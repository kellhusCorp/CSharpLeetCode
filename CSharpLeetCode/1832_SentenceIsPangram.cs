namespace CSharpLeetCode;

public class SentenceIsPangramSolution
{
    public bool CheckIfPangram(string sentence)
    {
        var d = new Dictionary<char, int>();
        foreach (var c in sentence)
        {
            if (!d.TryAdd(c, 1))
            {
                d[c] += 1;
            }
        }

        return d.Keys.Count == 26;
    }
}