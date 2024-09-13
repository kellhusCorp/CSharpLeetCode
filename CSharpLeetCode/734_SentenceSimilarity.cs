namespace CSharpLeetCode
{
    public class SentenceSimilaritySolution
    {
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1.Length != sentence2.Length)
            {
                return false;
            }
            
            var mapping = new Dictionary<string, HashSet<string>>();

            foreach (IList<string> similarityPair in similarPairs)
            {
                if (!mapping.ContainsKey(similarityPair[0]))
                {
                    mapping[similarityPair[0]] = new HashSet<string> { similarityPair[1] };
                }
                else
                {
                    mapping[similarityPair[0]].Add(similarityPair[1]);
                }

                if (!mapping.ContainsKey(similarityPair[1]))
                {
                    mapping[similarityPair[1]] = new HashSet<string>() { similarityPair[0] };
                }
                else
                {
                    mapping[similarityPair[1]].Add(similarityPair[0]);
                }
            }

            int i = 0, j = 0;

            while (i < sentence1.Length && j < sentence2.Length)
            {
                string left = sentence1[i];
                string right = sentence2[i];

                if (left == right)
                {
                    i++;
                    j++;
                    continue;
                }

                if (mapping.TryGetValue(left, out var similarity))
                {
                    if (similarity.Contains(right))
                    {
                        i++;
                        j++;
                        continue;
                    }
                }

                return false;
            }

            return sentence1.Length == i && sentence2.Length == j;
        }
    }
}