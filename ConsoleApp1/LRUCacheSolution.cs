using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LRUCacheSolution
    {
        public class LRUCache
        {
            public int key;
            public int value;
            public LRUCache next;
            public LRUCache prev;
            public LRUCache(int key, int value)
            {
                this.key = key;
                this.value = value;
                this.next = null;
                this.prev = null;
            }
        }
        LRUCache head;
        LRUCache tail;
        int cap;
        int size;
        Dictionary<int, LRUCache> hm;
        public LRUCacheSolution(int capacity)
        {
            head = new LRUCache(-1, -1);
            tail = new LRUCache(-1, -1);
            head.next = tail;
            tail.prev = head;
            cap = capacity;
            hm = new Dictionary<int, LRUCache>();
            size = 0;
        }

        public int get(int key)
        {
            if (hm.ContainsKey(key))
            {
                LRUCache x = hm[key];
                return x.value;
            }
            return -1;
        }

        public void set(int key, int value)
        {
            int val = -1;
            if (hm.ContainsKey(key))
            {
                val = hm[key].value;
            }
            if (val == value)
            {
                LRUCache x = hm[key];
                x = Delete(x);
                size--;
                LRUCache node = AddtoTail(x);
                size++;
            }
            else
            {
                LRUCache node1 = new LRUCache(key, value);
                if (hm.ContainsKey(key))
                {
                    LRUCache x = Delete(hm[key]);
                    size--;
                    hm.Remove(x.key);
                }
                else if (size == cap)
                {
                        LRUCache x = Delete(head.next);
                        size--;
                        hm.Remove(x.key);
                    
                }
                
                LRUCache node = AddtoTail(node1);
                size++;
                hm.Add(key, node);
            }
        }
        public LRUCache AddtoTail(LRUCache temp)
        {
            temp.next = tail;
            temp.prev = tail.prev;
            tail.prev.next = temp;
            tail.prev = temp;
            return temp;
        }
        public LRUCache Delete(LRUCache temp)
        {
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;
            return temp;
        }
    }
}
