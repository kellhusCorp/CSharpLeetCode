namespace CSharpLeetCode;

public class CountNumberOfConsistentStringSolution 
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        short counter = 0;

        foreach (var word in words)
        {
            var foundDeniedLetter = word.Any(c => !allowed.Contains(c));

            if (!foundDeniedLetter)
            {
                counter++;
            }
        }

        return counter;
    } 
}