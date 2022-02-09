using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Deque
    {
        public class DequeDLL
        {
            public int val;
            public DequeDLL next;
            public DequeDLL prev;
            public DequeDLL(int x)
            {
                this.val = x;
                this.next = null;
                this.prev = null;
            }
        }
        DequeDLL head;
        DequeDLL tail;
        public int Size;
        public Deque()
        {
            head = new DequeDLL(-1);
            tail = new DequeDLL(-1);
            head.next = tail;
            tail.prev = head;
            Size = 0;
        }
        public void EnqueueRear(int x)
        {
            DequeDLL temp= new DequeDLL(x);
            temp.prev = tail.prev;
            temp.next = tail;
            tail.prev.next = temp;
            tail.prev = temp;
            Size++;

        }
        public int DequeueRear()
        {
            if (Size > 0)
            {
                DequeDLL node = tail.prev;
                tail.prev.prev.next = tail;
                tail.prev = tail.prev.prev;
                Size--;
                return node.val;
            }
            return -1;

        }
        public int DequeueFront()
        {
            if (Size > 0)
            {
                DequeDLL node = head.next;
                node.next.prev= head;
                head.next = node.next;
                Size--;
                return node.val;
            }
            return -1;

        }
        public void EnqueueFront(int x)
        {
            DequeDLL temp = new DequeDLL(x);
            head.next.prev = temp;
            temp.prev = head;
            temp.next = head.next;
            head.next = temp;
            Size++;
        }
        public int PeekRear()
        {
            if (Size > 0)
            {
                return tail.prev.val;
            }
            return -1;
        }
        public int PeekFront()
        {
            if (Size > 0)
            {
                return head.next.val;
            }
            return -1;
        }
    }
}
