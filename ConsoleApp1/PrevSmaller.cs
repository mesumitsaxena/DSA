using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrevSmaller
    {
        public List<int> prevSmaller(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> output = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[i] <= stack.Peek())
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    output.Add(-1);
                    stack.Push(A[i]);
                }
                else
                {
                    output.Add(stack.Peek());
                    stack.Push(A[i]);
                }
            }
            return output;
        }
    }
}
