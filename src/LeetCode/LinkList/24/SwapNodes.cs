namespace LeetCode.LinkList._24;

public class SwapNodes
{
    public static void Run()
    {
        Console.WriteLine("24. Swap Nodes in Pairs: ");
        var l6 = new ListNode(6, null);
        var l5 = new ListNode(5, l6);
        var l4 = new ListNode(4, l5);
        var l3 = new ListNode(3, l4);
        var l2 = new ListNode(2, l3);
        var l1 = new ListNode(1, l2);
        LinkListUtility.PrintList(SwapNodes.SwapPairs(l1));
    }

    public static ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        var newHead = head.next;
        var node1 = head;
        var node2 = head.next;
        ListNode prev = null;

        while (node1 != null && node1.next != null)
        {
            var temp = node2.next;
            node1.next = temp;
            node2.next = node1;

            if (prev != null)
                prev.next = node2;
            prev = node1;

            node1 = temp;
            if (temp != null)
                node2 = temp.next;
        }

        return newHead;
    }
}
