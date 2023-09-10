namespace LeetCode.LinkList._206;

public class ReverseLinkList
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        ListNode next = null;
        ListNode current = head;

        while (current != null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        head = previous;
        return head;
    }
}
