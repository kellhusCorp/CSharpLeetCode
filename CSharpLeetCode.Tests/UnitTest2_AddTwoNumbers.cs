namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest2_AddTwoNumbers
    {
        [Test]
        public void Test_AddTwoNumbersSolution_AddTwoNumbers_FirstCase()
        {
            var firstList = new ListNode(2, new ListNode(4, new ListNode(3)));
            var secondList = new ListNode(5, new ListNode(6, new ListNode(4)));
            var solution = new AddTwoNumbersSolution();

            var result = solution.AddTwoNumbers(firstList, secondList);
            
            Assert.That(result.next.val, Is.EqualTo(0));
        }
        
        [Test]
        public void Test_AddTwoNumbersSolution_AddTwoNumbers_SecondCase()
        {
            var firstList = new ListNode(0);
            var secondList = new ListNode(0);
            var solution = new AddTwoNumbersSolution();

            var result = solution.AddTwoNumbers(firstList, secondList);
            
            Assert.That(result.val, Is.EqualTo(0));
        }
        
        [Test]
        public void Test_AddTwoNumbersSolution_AddTwoNumbers_ThirdCase()
        {
            var firstList = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var secondList = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var solution = new AddTwoNumbersSolution();

            var result = solution.AddTwoNumbers(firstList, secondList);

            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(8));
                Assert.That(result.next.val, Is.EqualTo(9));
                Assert.That(result.next.next.val, Is.EqualTo(9));
                Assert.That(result.next.next.next.val, Is.EqualTo(9));
                Assert.That(result.next.next.next.next.val, Is.EqualTo(0));
                Assert.That(result.next.next.next.next.next.val, Is.EqualTo(0));
                Assert.That(result.next.next.next.next.next.next.val, Is.EqualTo(0));
                Assert.That(result.next.next.next.next.next.next.next.val, Is.EqualTo(1));
            });
        }
        
        [Test]
        public void Test_AddTwoNumbersSolution_AddTwoNumbers_FourthCase()
        {
            var firstList = new ListNode(1, new ListNode(8));
            var secondList = new ListNode(0);
            var solution = new AddTwoNumbersSolution();

            var result = solution.AddTwoNumbers(firstList, secondList);
            
            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(1));
                Assert.That(result.next.val, Is.EqualTo(8));
            });
        }
    }
}