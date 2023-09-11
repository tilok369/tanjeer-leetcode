namespace LeetCode.LinkList._234;

public class PalindromeLinkList
{
    public static void Run()
    {
        var i4 = new ListNode(1);
        var i3 = new ListNode(2, i4);
        var i2 = new ListNode(2, i3);
        var i1 = new ListNode(1, i2);

        var j2 = new ListNode(1);
        var j1 = new ListNode(2, j2);

        Console.WriteLine("234. Linked List Palindrome:");
        Console.WriteLine(PalindromeLinkList.IsPalindrome(i1));
        Console.WriteLine(PalindromeLinkList.IsPalindrome(j1));
    }

    public static bool IsPalindrome(ListNode head)
    {
        var items = new List<int>();
        var node = head;

        while (node != null)
        {
            items.Add(node.val);
            node = node.next;
        }

        var count = items.Count;
        for (int i = 0; i < count / 2; i++)
        {
            if (items[i] != items[count - i - 1])
                return false;
        }

        return true;
    }
}
