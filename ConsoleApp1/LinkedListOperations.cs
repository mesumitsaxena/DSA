using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public int val;
        public Node next;
        public Node(int x)
        {
            this.val = x;
            this.next = null;
        }
    }
    internal class LinkedListOperations
    {
        static Node head = null;
        public static Node insert_node(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            Node ins = new Node(value);
            if (head == null) { head = ins; }
            else if (position == 1)
            {
                ins.next = head;
                head = ins;
            }
            else
            {
                Node temp = head;
                position--;
                while (position > 1 && temp.next != null)
                {
                    temp = temp.next;
                    position--;
                }
                ins.next = temp.next;
                temp.next = ins;

            }
            return head;

        }

        public static void delete_node(int position)
        {
            if (head != null)
            {
                if (position == 1)
                {
                    head = head.next;
                }
                else
                {
                    position--;
                    Node temp = head;
                    while (position > 1 && temp.next != null)
                    {
                        temp = temp.next;
                        position--;
                    }
                    temp.next = temp.next.next;
                }
            }
        }

        public static void print_ll()
        {
            // Output each element followed by a space
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.val + " ");
                temp = temp.next;
            }
        }
        public static Node reverseBetween(Node A, int B, int C)
        {
            if (A == null) return A;
            Node prev = null;
            Node curr = A;
            Node nxt = null;
            B--;
            C--;
            int count = (C - B) + 1;
            int j = B;
            while (j > 0 && curr != null)
            {
                prev = curr;
                curr = curr.next;
                j--;
            }
            Node last = prev;
            Node final = curr;
            prev = null;
            
            while (count > 0 && curr != null)
            {
                nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
                count--;
            }
            if (B == 0)
            {
                A.next = curr;
                return prev;
            }
            last.next = prev;
            final.next = curr;
            return A;
        }
    }
}
