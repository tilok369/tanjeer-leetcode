﻿
using LeetCode.LinkList;

namespace LeetCode
{

    public class PalindromeLinkLists
    {
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
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