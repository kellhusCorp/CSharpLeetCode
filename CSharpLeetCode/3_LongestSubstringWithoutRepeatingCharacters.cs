namespace CSharpLeetCode
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        // O(n^2)
        public int LengthOfLongestSubstring(string s)
        {
            var maxLength = 0;
            for (int startIndex = 0; startIndex < s.Length; startIndex++)
            {
                var set = new HashSet<char>
                {
                    s[startIndex]
                };
                for (int endIndex = startIndex + 1; endIndex < s.Length; endIndex++)
                {
                    var result = set.Add(s[endIndex]);
                    if (!result)
                    {
                        break;
                    }
                }
                
                if (set.Count > maxLength)
                {
                    maxLength = set.Count;
                }
            }

            return maxLength;
        }
    }
}