namespace CSharpLeetCode
{
    public class IsomorphicStringsSolution 
    {
        public bool IsIsomorphic(string s, string t)
        {
            var sTransformed = Transform(s);
            var tTransformed = Transform(t);
            return Equals(sTransformed, tTransformed);
        }

        private static bool Equals(IReadOnlyList<int> firstArr, IReadOnlyList<int> secondArr)
        {
            if (firstArr.Count != secondArr.Count)
                return false;

            for (int i = 0; i < firstArr.Count; i++)
            {
                if (firstArr[i] != secondArr[i]) return false;
            }

            return true;
        }
        
        private static int[] Transform(string s)
        {
            var d = new Dictionary<char, int>();
            var arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (!d.ContainsKey(s[i]))
                {
                    d[s[i]] = i;
                }

                arr[i] = d[s[i]];
            }

            return arr;
        }
    }
}