namespace CSharpLeetCode
{
    public class HighFiveSolution
    {
        public int[][] HighFive(int[][] items) 
        {
            Dictionary<int, PriorityQueue<int, int>> d = new();
            foreach (int[] item in items)
            {
                if (!d.ContainsKey(item[0]))
                    d.Add(item[0], new PriorityQueue<int, int>());
                d[item[0]].Enqueue(item[1], int.MaxValue - item[1]);
            }

            var result = new int[d.Keys.Count][];
            var j = 0;
            foreach(var pair in d.OrderBy(x => x.Key))
            {
                result[j] = new int[2];
                result[j][0] = pair.Key;
                var sum = 0;
                var counter = 0;
                while (counter < 5 && pair.Value.Count > 0)
                {
                    sum += pair.Value.Dequeue();
                    counter++;
                }

                result[j][1] = sum / 5;
                j++;
            }

            return result;
        }
    }
}