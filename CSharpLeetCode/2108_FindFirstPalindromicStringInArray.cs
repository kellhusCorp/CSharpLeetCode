namespace CSharpLeetCode
{
    public class FindFirstPalindromicStringInArraySolution
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                if (IsPalindrome(word)) return word;
            }

            return string.Empty;
        }

        private static bool IsPalindrome(string word)
        {
            for(int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                if (word[i] != word[j]) return false;
            }

            return true;
        }
    }
}