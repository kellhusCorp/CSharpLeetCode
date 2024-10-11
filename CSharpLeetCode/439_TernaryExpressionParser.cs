namespace CSharpLeetCode
{
    public class TernaryExpressionParser
    {
        public string ParseTernary(string expression)
        {
            var stack = new Stack<char>();

            var idx = expression.Length - 1;

            while (idx >= 0)
            {
                var c = expression[idx];

                if (IsValue(c))
                {
                    stack.Push(c);
                }
                else if (c == '?')
                {
                    var truthExpression = stack.Pop();
                    var otherwiseExpression = stack.Pop();
                    var condition = expression[idx - 1];
                    stack.Push(SolveExpression(condition, truthExpression, otherwiseExpression));
                    idx--;
                }
                
                idx--;
            }

            return stack.Pop().ToString();
        }

        private static char SolveExpression(char condition, char truthExpression, char otherwiseExpression)
        {
            if (condition == 'T')
            {
                return truthExpression;
            }

            return otherwiseExpression;
        }
        
        private static bool IsValue(char c)
        {
            return c is >= '0' and <= '9' or 'T' or 'F';
        }
    }
}