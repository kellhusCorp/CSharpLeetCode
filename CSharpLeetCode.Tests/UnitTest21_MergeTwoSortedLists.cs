namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest21_MergeTwoSortedLists
    {
        [Test]
        public void Test_MergeTwoSortedListsSolution_MergeTwoLists_FirstCase()
        {
            var firstList = new ListNode(1, new ListNode(2, new ListNode(4)));
            var secondList = new ListNode(1, new ListNode(3, new ListNode(4)));
            var solution = new MergeTwoSortedListsSolution();
            
            var result = solution.MergeTwoLists(firstList, secondList);
            
            Assert.Multiple(() =>
            {
                Assert.That(result.val, Is.EqualTo(1));
                Assert.That(result.next.val, Is.EqualTo(1));
                Assert.That(result.next.next.val, Is.EqualTo(2));
                Assert.That(result.next.next.next.val, Is.EqualTo(3));
                Assert.That(result.next.next.next.next.val, Is.EqualTo(4));
                Assert.That(result.next.next.next.next.next.val, Is.EqualTo(4));
            });
        }

        [Test]
        public void Test_MergeTwoSortedListsSolution_MergeTwoLists_SecondCase()
        {
            ListNode firstList = null;
            var secondList = new ListNode();
            var solution = new MergeTwoSortedListsSolution();
            
            var result = solution.MergeTwoLists(firstList, secondList);
            
            Assert.That(result.val, Is.EqualTo(0));
        }
    }
}