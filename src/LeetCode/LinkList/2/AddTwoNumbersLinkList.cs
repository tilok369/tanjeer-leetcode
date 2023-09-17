namespace LeetCode.LinkList._2;

public  class AddTwoNumbersLinkList
{
    public static void Run()
    {
        Console.WriteLine("Add Two Numbers:");

        var i3 = new ListNode(3);
        var i2 = new ListNode(4, i3);
        var i1 = new ListNode(2, i2);

        var j3 = new ListNode(4);
        var j2 = new ListNode(6, j3);
        var j1 = new ListNode(5, j2);

        LinkListUtility.PrintList(AddTwoNumbersLinkList.AddTwoNumbers(i1, j1));
        Console.WriteLine();
        var k1 = new ListNode(0);
        var l1 = new ListNode(0);

        LinkListUtility.PrintList(AddTwoNumbersLinkList.AddTwoNumbers(k1, l1));
        Console.WriteLine();
        var m7 = new ListNode(9);
        var m6 = new ListNode(9, m7);
        var m5 = new ListNode(9, m6);
        var m4 = new ListNode(9, m5);
        var m3 = new ListNode(9, m4);
        var m2 = new ListNode(9, m3);
        var m1 = new ListNode(9, m2);

        var n4 = new ListNode(9);
        var n3 = new ListNode(9, n4);
        var n2 = new ListNode(9, n3);
        var n1 = new ListNode(9, n2);

        LinkListUtility.PrintList(AddTwoNumbersLinkList.AddTwoNumbers(m1, n1));
        Console.WriteLine();
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode(0);
        var head = result;
        var cf = 0;
        while (l1 != null || l2 != null)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + cf;
            cf = sum / 10;

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
            result.next = new ListNode(sum % 10);
            result = result.next;
        }
        if (cf > 0)
            result.next = new ListNode(cf);

        return head.next;
    }
}