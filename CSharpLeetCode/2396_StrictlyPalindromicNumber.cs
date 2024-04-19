namespace CSharpLeetCode
{
    public class StrictlyPalindromicNumberSolution
    {
        public bool IsStrictlyPalindromic(int n)
        {
            var bases = Enumerable.Range(2, n - 2).Select(x => MoveToBase(n, x));

            foreach (string @base in bases)
            {
                for (int i = 0, j = @base.Length - 1; i < @base.Length / 2; i++, j--)
                {
                    if (@base[i] != @base[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public string MoveToBase(int n, int @base)
        {
            Stack<int> stack = new();
            
            while (n / @base != 0)
            {
                stack.Push(n % @base);
                n /= @base;
            }
            
            stack.Push(n);

            return @base == 16 ? GetHex(stack) : string.Join(string.Empty, stack);
        }

        private string GetHex(Stack<int> stack)
        {
            var count = stack.Count;
                
            char[] array = new char[stack.Count];
            for (int i = 0; i < count; i++)
            {
                int value = stack.Pop();
                if (value >= 10)
                {
                    array[i] = (char)(value + 55);
                }
                else
                {
                    array[i] = (char)(value + 48);
                }
            }
                
            return new string(array);
        }
    }
}