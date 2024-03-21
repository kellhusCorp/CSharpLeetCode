namespace CSharpLeetCode
{
    public class EvaluateReversePolishNotationSolution
    {
        private readonly IDictionary<string, Func<int, int, int>> _operators = new Dictionary<string, Func<int, int, int>>()
        {
            ["+"] = (x, y) => x + y,
            ["-"] = (x, y) => x - y,
            ["*"] = (x, y) => x * y,
            ["/"] = (x, y) => x / y
        };
        
        public int EvalRPN(string[] tokens)
        {
            var operations = new Stack<int>();

            foreach (string token in tokens)
            {
                if (!_operators.ContainsKey(token))
                {
                    operations.Push(int.Parse(token));
                }
                else
                {
                    var firstElement = operations.Pop();
                    var secondElement = operations.Pop();
                    operations.Push(_operators[token](secondElement, firstElement));
                }
            }

            return operations.Pop();
        }
    }
}