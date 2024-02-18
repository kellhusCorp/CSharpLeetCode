namespace CSharpLeetCode.Tests
{
    public class UnitTest202HappyNumber
    {
        private HappyNumberSolution _solution;
        [SetUp]
        public void SetUp()
        {
            _solution = new HappyNumberSolution();
        }
        
        [Test]
        public void Test_HappyNumber_IsHappy_Returns_False_When_Number_Equals_2()
        {
            var number = 2;

            var result = _solution.IsHappy(number);
            
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_HappyNumber_IsHappy_Returns_True_When_Number_Equals_19()
        {
            var number = 19;

            var result = _solution.IsHappy(number);
            
            Assert.That(result, Is.True);
        }
    }
}