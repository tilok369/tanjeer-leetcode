namespace LeetCode.LinkList._876;

public class MiddleNodeLinkList
{
    public static void Run()
    {
        var i8 = new ListNode(8);
        var i7 = new ListNode(7, i8);
        var i6 = new ListNode(6, i7);
        var i5 = new ListNode(5, i6);
        var i4 = new ListNode(4, i5);
        var i3 = new ListNode(3, i4);
        var i2 = new ListNode(2, i3);
        var i1 = new ListNode(1, i2);

        var j7 = new ListNode(7);
        var j6 = new ListNode(6, j7);
        var j5 = new ListNode(5, j6);
        var j4 = new ListNode(4, j5);
        var j3 = new ListNode(3, j4);
        var j2 = new ListNode(2, j3);
        var j1 = new ListNode(1, j2);



        Console.WriteLine("876. Middle of the Linked List:");
        Console.WriteLine(MiddleNodeLinkList.MiddleNode(j1).val);
        Console.WriteLine(MiddleNodeLinkList.MiddleNode(i1).val);
    }

    public static ListNode MiddleNode(ListNode head)
    {
        var node = head;
        var length = 0;
        while (node != null)
        {
            length++;
            node = node.next;
        }

        node = head;
        for (int i = 0; i < (length / 2); i++)
        {
            node = node.next;
        }

        return node;
    }
}
