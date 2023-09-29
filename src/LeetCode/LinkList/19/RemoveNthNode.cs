namespace LeetCode.LinkList._19;

public class RemoveNthNode
{
    public static void Run()
    {
        Console.WriteLine("19. Remove Nth Node From End of List: ");
        var l5 = new ListNode(5, null);
        var l4 = new ListNode(4, l5);
        var l3 = new ListNode(3, l4);
        var l2 = new ListNode(2, l3);
        var l1 = new ListNode(1, l2);
        LinkListUtility.PrintList(RemoveNthNode.RemoveNthFromEnd(l1, 2));
        LinkListUtility.PrintList(RemoveNthNode.RemoveNthFromEnd(l5, 1));

    }

    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var tempNode = new ListNode(-1);
        tempNode.next = head;

        var start = tempNode;
        var end = tempNode;

        var i = 0;
        while (i < n)
        {
            end = end.next;
            i++;
        }

        while (end != null && end.next != null)
        {
            end = end.next;
            start = start.next;
        }

        start.next = start.next.next;
        return tempNode.next;
    }
}
