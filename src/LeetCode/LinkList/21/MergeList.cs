namespace LeetCode.LinkList._21;

public class MergeList
{
    public static void Run()
    {
        Console.WriteLine("21. Merge Two Sorted Lists: ");

        var list13 = new ListNode(4, null);
        var list12 = new ListNode(2, list13);
        var list1 = new ListNode(1, list12);

        var list23 = new ListNode(4, null);
        var list21 = new ListNode(3, list23);
        var list2 = new ListNode(1, list21);
        LinkListUtility.PrintList(MergeList.MergeTwoLists(list1, list2));
        Console.WriteLine();
        var list3 = new ListNode(0, null);
        LinkListUtility.PrintList(MergeList.MergeTwoLists(list3, null));
        Console.WriteLine();
        LinkListUtility.PrintList(MergeList.MergeTwoLists(null, null));
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var node1 = list1;
        var node2 = list2;
        var merged = new ListNode();
        var head = merged;

        while (node1 != null || node2 != null)
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
            merged = merged.next;
        }

        return head.next;
    }
}
