namespace CSharpLeetCode;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 * public int val;
 * public ListNode next;
 * public ListNode(int val=0, ListNode next=null) {
 * this.val = val;
 * this.next = next;
 * }
 * }
 */
public class MergeNodesInBetweenZerosSolution
{
    public ListNode MergeNodes(ListNode head)
    {
        var node = head;

        while (node.next != null)
        {
            var next = node.next;

            var temp = next.next;
            next.next = null;

            if (next.val != 0)
                node.val += next.val;
            else if (next.val == 0 && temp != null)
                node = next;

            node.next = temp;
        }

        return head;
    }
}