using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class FirstNonRepeatingChar_Q
    {
        public string solve(string A)
        {
            Queue<char> Q = new Queue<char>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Dictionary<char, int> hm = new Dictionary<char, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (hm.ContainsKey(A[i]))
                {
                    hm[A[i]]++;
                }
                else
                {
                    hm.Add(A[i], 1);
                }
                Q.Enqueue(A[i]);
                while (Q.Count > 0 && hm.ContainsKey(Q.Peek()) && hm[Q.Peek()] > 1)
                {
                    Q.Dequeue();
                }
                if (Q.Count > 0)
                {
                    sb.Append(Q.Peek());
                }
                else
                {
                    sb.Append("#");
                }
            }
            return sb.ToString();
        }
    }
}
