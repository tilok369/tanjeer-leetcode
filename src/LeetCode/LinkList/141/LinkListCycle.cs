using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkList._141;

public class LinkListCycle
{
    public static void Run()
    {
        Console.WriteLine("141. Link List Cycle: ");
        var l4 = new ListNode(-4, null);
        var l3 = new ListNode(0, l4);
        var l2 = new ListNode(2, l3);
        var l1 = new ListNode(3, l2);
        l4.next = l2;

        Console.WriteLine(HasCycle(l1));
        Console.WriteLine(HasCycleOpt(l1));
    }

    private static bool HasCycle(ListNode head)
    {
        var nodes = new HashSet<ListNode>();

        while (head != null)
        {
            if (nodes.Contains(head))
                return true;

            nodes.Add(head);
            head = head.next;
        }

        return false;
    }

    private static bool HasCycleOpt(ListNode head)
    {
        if (head == null)
            return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;          // move 1 step
            fast = fast.next.next;    // move 2 steps

            if (slow == fast)
                return true;
        }

        return false;
    }
}
