using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CountRectangle
    {
        public int solve(List<int> A, List<int> B)
        {
            int n = A.Count;
            Dictionary<int, HashSet<int>> mpx = new Dictionary<int, HashSet<int>>();
            HashSet<int> h;
            for (int i = 0; i < n; i++)
            {
                if (mpx.ContainsKey(A[i]))
                    h = mpx[A[i]];
                else
                    h = new HashSet<int>();
                h.Add(B[i]);
                mpx[A[i]] = h;
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] == A[j] || B[i] == B[j])
                        continue;
                    if (mpx[A[i]].Contains(B[j]) && mpx[A[j]].Contains(B[i]))
                        ans++;
                }
            }
            return ans / 2;
        }

    }
}
