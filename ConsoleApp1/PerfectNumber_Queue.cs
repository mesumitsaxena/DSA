using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PerfectNumber_Queue
    {
        public int reverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            return reverse;
        }
        public string reverse(System.Text.StringBuilder sb)
        {
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                sb1.Append(sb[i]);
            }
            return sb1.ToString();
        }
        public string solve(string A)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < A.Length; i++)
            {
                if (stack.Count > 0 && A[i] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(A[i]);
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Peek());
                stack.Pop();
            }
            string output = reverse(sb);
            return output;
        }
        public List<int> solve(List<int> A, int B)
        {
            Queue<int> Q = new Queue<int>();
            for (int i = 0; i < B; i++)
            {
                Q.Enqueue(A[i]);
            }
            Stack<int> S = new Stack<int>();
            while (Q.Count > 0)
            {
                S.Push(Q.Peek());
                Q.Dequeue();
            }
            int j = 0;
            while (S.Count > 0 && j < B)
            {
                A[j] = S.Pop();
                j++;
            }
            return A;
        }
        public string solve(int A)
        {
            Queue<int> Q = new Queue<int>();
            int count = 0;
            for (int i = 1; i <= 2; i++)
            {
                Q.Enqueue(i);
                if (count == A)
                {
                    return (10 * i + i).ToString();
                }
            }
            while (count != A)
            {
                int val = Q.Peek();
                Q.Dequeue();
                for (int i = 1; i <= 2; i++)
                {
                    int val1 = val * 10 + i;
                    Q.Enqueue(val1);
                    count++;
                    if (count == A)
                    {
                        int rev = reverse(val1);
                        string num = val1.ToString() + rev.ToString();
                        return num;
                    }
                }
            }
            return "1";
        }
    }
}
