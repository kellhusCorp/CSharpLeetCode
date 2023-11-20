namespace CSharpLeetCode
{
    public class WordPatternSolution 
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split();
            var wordMap = new Dictionary<string, char>();
            var charMap = new Dictionary<char, string>();

            if (pattern.Length != words.Length) return false;
            
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!charMap.ContainsKey(pattern[i]))
                {
                    if (wordMap.ContainsKey(words[i]))
                    {
                        return false;
                    }

                    charMap.Add(pattern[i], words[i]);
                    wordMap.Add(words[i], pattern[i]);
                }
                else
                {
                    if (words[i] != charMap[pattern[i]]) return false;
                }
            }

            return true;
        }

        public bool WordPatternAnotherOne(string pattern, string s)
        {
            var words = s.Split();

            var map = new Dictionary<string, int>();

            if (pattern.Length != words.Length) return false;

            var keyForChar = "char_{0}";
            
            for (int i = 0; i < words.Length; i++)
            {
                string charKey = string.Format(keyForChar, pattern[i]);
                if (!map.ContainsKey(charKey))
                {
                    map.Add(charKey, i);
                }

                if (!map.ContainsKey(words[i]))
                {
                    map.Add(words[i], i);
                }

                if (map[words[i]] != map[charKey])
                {
                    return false;
                }
            }

            return true;
        }
    }
}