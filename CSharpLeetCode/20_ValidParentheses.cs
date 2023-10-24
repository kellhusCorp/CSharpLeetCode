namespace CSharpLeetCode
{
    public class ValidParenthesesSolution
    {
        private static readonly IReadOnlyCollection<char> BracesOpened = new List<char> { '(', '{', '[' };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (IsOpened(c))
                {
                    stack.Push(GetReverse(c));
                }
                else
                {
                    stack.TryPop(out char brace);
                    if (brace != c) return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool IsOpened(char c) => BracesOpened.Contains(c);

        private static char GetReverse(char c)
        {
            return c switch
            {
                '(' => ')',
                '{' => '}',
                '[' => ']',
                _ => throw new ArgumentOutOfRangeException(nameof(c))
            };
        }
    }
}