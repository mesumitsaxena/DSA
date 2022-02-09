using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }
    internal class MiddleElementinLinkedList
    {
        public int solve(ListNode A)
        {
            int k = 1;
            if (A == null) return 0;
            ListNode temp = A;
            while (temp.next != null)
            {
                temp = temp.next;
                k++;
            }
            k = (k / 2);
            ListNode temp1 = A;
            while (k > 0 && temp1.next != null)
            {
                temp1 = temp1.next;
                k--;
            }
            return temp1.val;
        }
    }
}
