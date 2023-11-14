namespace CSharpLeetCode
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (!strs.Any())
            {
                return string.Empty;
            }

            var prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (!prefix.Any())
                    {
                        return string.Empty;
                    }
                }
            }

            return prefix;
        }
    }
}