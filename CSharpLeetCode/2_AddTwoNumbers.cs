namespace CSharpLeetCode
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = l1.val + l2.val;
            int remVal = val / 10;
            var result = new ListNode(val % 10);
            var node = result;
            var l = l1.next;
            var r = l2.next;
            while (l != null || r != null || remVal != 0)
            {
                var x = l?.val ?? 0;
                var y = r?.val ?? 0;
                var sum = x + y + remVal;
                node.next = new ListNode(sum % 10);
                remVal = sum / 10;
                l = l?.next;
                r = r?.next;
                node = node.next;
            }
            
            return result;
        }
    }
}