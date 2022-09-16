
namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class PalindromeLinkList
    {
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
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
            for (int i = 0; i < count/2; i++)
            {
                if(items[i] != items[count - i -1])
                    return false;
            }

            return true;
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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var head = result;
            var cf = 0;
            while (l1 != null || l2 != null)
            { 
                var sum = (l1?.val??0) + (l2?.val??0) + cf;
                cf = sum / 10;

                if(l1 != null)
                    l1 = l1.next; 
                if(l2 != null)
                    l2 = l2.next;
                result.next = new ListNode(sum % 10);
                result = result.next;
            }
            if(cf > 0)
                result.next = new ListNode(cf);

            return head.next;
        }
    }
}
