namespace LeetCode.LinkList._206;

public class ReverseLinkList
{
    public static void Run()
    {
        var i5 = new ListNode(5);
        var i4 = new ListNode(4, i5);
        var i3 = new ListNode(3, i4);
        var i2 = new ListNode(2, i3);
        var i1 = new ListNode(1, i2);

        var i7 = new ListNode(7);
        var i6 = new ListNode(6, i7);

        Console.WriteLine("206. Reverse Linked List: ");
        LinkListUtility.PrintList(ReverseLinkList.ReverseList(i1));
        LinkListUtility.PrintList(ReverseLinkList.ReverseList(i6));
    }

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
