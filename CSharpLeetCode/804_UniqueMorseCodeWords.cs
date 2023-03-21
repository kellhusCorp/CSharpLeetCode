using System.Text;

namespace CSharpLeetCode;

// 1 <= words.length <= 100
// 1 <= words[i].length <= 12

public class UniqueMorseCodeWordsSolution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        var fullTable = new[]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        var set = new HashSet<string>();

        foreach (var word in words)
        {
            var sb = new StringBuilder();
            foreach (var c in word) sb.Append(fullTable[c - 97]);

            var finalStr = sb.ToString();

            if (!set.Contains(finalStr)) set.Add(finalStr);
        }

        return set.Count;
    }
}