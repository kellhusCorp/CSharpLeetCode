namespace CSharpLeetCode.Tests;

public class UnitTest2181_MergeNodesInBetweenZeros
{
    [Test]
    public void Test_MergeNodes()
    {
        var head = GetHeadForFirstCase();

        var result = new MergeNodesInBetweenZerosSolution().MergeNodes(head);
        Assert.Multiple(() =>
        {
            Assert.That(result.val, Is.EqualTo(4));
            Assert.That(result.next.val, Is.EqualTo(11));
        });
    }

    private static ListNode GetHeadForFirstCase()
    {
        var head = new ListNode(0);
        var first = new ListNode(3);
        var second = new ListNode(1);
        var third = new ListNode(0);
        var fourth = new ListNode(4);
        var fifth = new ListNode(5);
        var sixth = new ListNode(2);
        var seventh = new ListNode(0);

        head.next = first;
        first.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = fifth;
        fifth.next = sixth;
        sixth.next = seventh;

        return head;
    }
}