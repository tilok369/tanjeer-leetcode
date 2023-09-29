
using LeetCode.LinkList;

namespace LeetCode;
public class LinkedList
{
    

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

            if(prev != null)
                prev.next = node2;
            prev = node1;

            node1 = temp;
            if(temp != null) 
                node2 = temp.next;
        }

        return newHead;
    }
}