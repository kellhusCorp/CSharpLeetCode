namespace CSharpLeetCode
{
    public class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            int first = 0;
            var second = 0;

            while (first < s.Length && second < t.Length)
            {
                if (s[first] == t[second])
                {
                    first++;
                }

                second++;
            }

            return first == s.Length;
        }
    }
}