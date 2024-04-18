namespace CSharpLeetCode
{
    public class PalindromePermutationSolution
    {
        public bool CanPermutePalindrome(string s)
        {
            var mapping = new Dictionary<char, int>();
            
            foreach (char c in s)
            {
                if (!mapping.TryAdd(c, 1))
                    mapping[c]++;
            }

            return mapping.Count(x => x.Value % 2 != 0) <= 1;
        }

        public bool CanPermutePalindromeModified(string s)
        {
            var mapping = s.GroupBy(c => c)
                .ToDictionary(grp => grp.Key, grp => grp.Count());
            
            return mapping.Count(x => x.Value % 2 != 0) <= 1;
        }
    }
}