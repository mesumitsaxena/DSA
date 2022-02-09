using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MinValStack
    {
        List<int> stack1 = new List<int>();
        List<int> stack2 = new List<int>();
        int top1 = -1;
        int curr_min = Int32.MaxValue;
        public void push(int x)
        {
            stack1.Add(x);
            if (curr_min > x)
            {
                curr_min = x;
            }
            stack2.Add(curr_min);
            top1++;

        }

        public void pop()
        {
            if (top1 != -1)
            {
                top1--;
            }
        }

        public int top()
        {
            if (top1 == -1)
            {
                return -1;
            }
            return top1;
        }

        public int getMin()
        {
            if (top1 == -1) return -1;
            int x = stack2[top1];
            return x;
        }
    }
}
