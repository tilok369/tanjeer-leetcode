using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkList._160;

public class LinkListIntersection
{
    public static void Run()
    {
        Console.WriteLine("160. Intersection of Two Linked Lists: ");
        //var l5 = new ListNode(5, null);
        //var l4 = new ListNode(4, l5);
        //var l3 = new ListNode(8, l4);
        //var l2 = new ListNode(1, l3);
        //var lA = new ListNode(4, l2);

        //var l6 = new ListNode(1, l3);
        //var l7 = new ListNode(6, l6);
        //var lB = new ListNode(5, l7);

        //Console.WriteLine(GetIntersectionNode(lA, lB)?.val.ToString() ?? "NULL");
        var l5 = new ListNode(4, null);
        var l4 = new ListNode(2, l5);
        var l3 = new ListNode(1, l4);
        var l2 = new ListNode(9, l3);
        var lA = new ListNode(1, l2);

        var lB = new ListNode(3, l4);

        Console.WriteLine(GetIntersectionNode(lA, lB)?.val.ToString() ?? "NULL");
    }

    private static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var nodes = new HashSet<ListNode>();

        while (headA != null || headB != null)
        {
            if (headA != null)
            {
                if(nodes.Contains(headA))
                    return headA;
                nodes.Add(headA);
                headA = headA.next;
            }
            if (headB != null)
            {
                if (nodes.Contains(headB))
                    return headB;
                nodes.Add(headB);
                headB = headB.next;
            }   
        }

        return null;
    }
}
