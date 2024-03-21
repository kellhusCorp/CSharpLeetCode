namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest150_EvaluateRPN
    {
        [Test]
        public void Test_EvaluateReversePolishNotationSolution_EvalRPN_FirstCase()
        {
            var tokens = new[] { "2", "1", "+", "3", "*" };

            var sol = new EvaluateReversePolishNotationSolution();

            var result = sol.EvalRPN(tokens);
            
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Test_EvaluateReversePolishNotationSolution_EvalRPN_SecondCase()
        {
            var tokens = new[] { "4","13","5","/","+" };

            var sol = new EvaluateReversePolishNotationSolution();

            var result = sol.EvalRPN(tokens);
            
            Assert.That(result, Is.EqualTo(6));
        }
        
        [Test]
        public void Test_EvaluateReversePolishNotationSolution_EvalRPN_ThirdCase()
        {
            var tokens = new[] { "10","6","9","3","+","-11","*","/","*","17","+","5","+" };

            var sol = new EvaluateReversePolishNotationSolution();

            var result = sol.EvalRPN(tokens);
            
            Assert.That(result, Is.EqualTo(22));
        }
    }
}