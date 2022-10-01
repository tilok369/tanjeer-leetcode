
namespace LeetCode;
public class LinkedList
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var node1 = list1;
        var node2 = list2;
        var merged = new ListNode();

        while (node1 != null && node2 != null)
        {
            if (node1 == null)
            {
                merged.next = new ListNode(node2.val);
                node2 = node2.next;
            }
            else if (node2 == null)
            {
                merged.next = new ListNode(node1.val);
                node1 = node1.next;
            }
            else if (node1.val <= node2.val)
            {
                merged.next = new ListNode(node1.val);
                node1 = node1.next;
            }
            else
            {
                merged.next = new ListNode(node2.val);
                node2 = node2.next;
            }
        }

        return merged.next;
    }
}