namespace CSharpLeetCode
{
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var fakeNode = new ListNode();
            var node = fakeNode;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }

                node = node.next;
            }

            node.next = list1 == null ? list2 : list1;

            return fakeNode.next;
        }
    }
}