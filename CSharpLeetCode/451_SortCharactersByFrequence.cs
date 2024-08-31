using System.Text;

namespace CSharpLeetCode
{
    public class SortCharactersByFrequencySolution
    {
        public string FrequencySort(string s)
        {
            var freqMapping = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (freqMapping.TryGetValue(s[i], out int _))
                {
                    freqMapping[s[i]]++;
                }
                else
                {
                    freqMapping[s[i]] = 1;
                }
            }

            var buckets = new List<char>[s.Length + 1];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<char>();
            }

            foreach (KeyValuePair<char,int> pair in freqMapping)
            {
                buckets[pair.Value].Add(pair.Key);
            }

            var result = new StringBuilder();
            for (int i = buckets.Length - 1; i >= 0; i--)
            {
                foreach (char c in buckets[i])
                {
                    result.Append(c, i);
                }
            }

            return result.ToString();
        }
    }
}