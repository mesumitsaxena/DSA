using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boring_Substring
    {
        public int solve(string A)
        {
            List<char> even = new List<char>();
            List<char> odd = new List<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    even.Add(A[i]);
                }
                else
                {
                    odd.Add(A[i]);
                }
            }
            for (int i = even.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < odd.Count; j++)
                {
                    int val = Math.Abs(even[i] - odd[j]);
                    if (val > 1)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
