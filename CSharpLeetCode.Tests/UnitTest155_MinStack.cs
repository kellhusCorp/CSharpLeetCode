namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest155_MinStack
    {
        [Test]
        public void Test_MinStack_FirstCase()
        {
            var minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.That(minStack.GetMin(), Is.EqualTo(-3));
            minStack.Pop();
            Assert.Multiple(() =>
            {
                Assert.That(minStack.Top(), Is.EqualTo(0));
                Assert.That(minStack.GetMin(), Is.EqualTo(-2));
            });
        }
        
        [Test]
        public void Test_MinStack_SecondCase()
        {
            var minStack = new MinStack();
            minStack.Push(0);
            minStack.Push(1);
            minStack.Push(0);
            Assert.That(minStack.GetMin(), Is.EqualTo(0));
            minStack.Pop();
            Assert.That(minStack.GetMin(), Is.EqualTo(0));
        }
    }
}