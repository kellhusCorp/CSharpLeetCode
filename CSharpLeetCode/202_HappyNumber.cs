namespace CSharpLeetCode
{
    public class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            while (n != 1)
            {
                n = GetSumOfSquares(n);
                if (!set.Add(n)) return false;
            }

            return true;
        }

        private static int GetSumOfSquares(int n)
        {
            return GetDigits(n).Select(x => x * x).Sum();
        }

        private static IEnumerable<int> GetDigits(int n)
        {
            while (n != 0)
            {
                yield return n % 10;
                n /= 10;
            }
        }
    }
}