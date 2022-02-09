using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PallindromLinkedList
    {
        public Node reverse(Node A)
        {
            if (A == null || A.next == null) return A;
            Node curr = A;
            Node prev = null;
            Node nxt = null;
            while (curr != null)
            {
                nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }
            return prev;
        }
        public int countNodes(Node A)
        {
            if (A == null) return 0;
            Node temp = A;
            int count = 1;
            while(temp.next!= null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public int lPalin(Node A)
        {
            if (A == null || A.next == null) return 1;
            Node slow = A;
            Node fast = A;
            Node prev = null;
            int count = 1;
            while (fast.next != null && fast.next.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
                count++;
            }
            Node List1 = A;
            Node List2 = slow.next;
            if (countNodes(A) % 2 > 0)
            {
                prev.next = null;
            }
            else
            {
                slow.next = null;
            }
            List1 = reverse(List1);
            while (List1 != null && List2 != null)
            {
                if (List1.val != List2.val)
                {
                    return 0;
                }
                List1 = List1.next;
                List2 = List2.next;
            }
            return 1;
        }
    }
}
