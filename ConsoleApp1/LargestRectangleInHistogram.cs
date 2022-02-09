using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LargestRectangleInHistogram
    {
        public List<int> SmallestatLeft(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> output = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[stack.Peek()] >= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    output.Add(-1);
                }
                else
                {
                    output.Add(stack.Peek());
                }
                stack.Push(i);
            }
            return output;
        }
        public List<int> SmallestatRight(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> output = new List<int>();
            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && A[stack.Peek()] >= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    output.Add(A.Count);
                }
                else
                {
                    output.Add(stack.Peek());
                }
                stack.Push(i);
            }
            return output;
        }
        public int largestRectangleArea(List<int> A)
        {
            Queue<int> Q = new Queue<int>();
            List<int> leftsmaller = SmallestatLeft(A);
            List<int> rightsmaller = SmallestatRight(A);
            int ans = Int32.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                int val = (rightsmaller[A.Count-1-i] - leftsmaller[i] - 1) * A[i];
                ans = Math.Max(val, ans);
            }
            return ans;
        }
    }
}
