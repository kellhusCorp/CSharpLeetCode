namespace CSharpLeetCode
{
    public class FindIndexOfFirstOccurenceInStringSolution 
    {
        public int StrStr(string haystack, string needle)
        {
            var n = haystack.Length;
            var m = needle.Length;

            for (int i = 0; i <= n - m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (needle[j] != haystack[i + j])
                    {
                        break;
                    }

                    if (j == m - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;

            // return haystack.IndexOf(needle, StringComparison.Ordinal);
        }
    }
}