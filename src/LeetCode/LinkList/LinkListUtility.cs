namespace LeetCode.LinkList;

public class LinkListUtility
{
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " ");
            node = node.next;
        }
    }
}
