using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SubArrayWithGivenSum
    {
        public List<int> solve(List<int> A, int B)
        {
            int l = 0;
            int r = 1;
            List<int> ans = new List<int>() { -1 };
            List<int> pf = new List<int>();
            pf.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                pf.Add(pf[i - 1] + A[i]);
                if (pf[i] == B)
                {
                    ans = new List<int>();
                    ans.Add(1);
                    ans.Add(i + 1);
                }
            }
            while (r<A.Count)
            {
                if (pf[r] + pf[l] == B)
                {
                    ans = new List<int>();
                    ans.Add(l + 1);
                    ans.Add(r + 1);
                    l++;
                    r--;
                }
                else if (pf[r] - pf[l] > B)
                {
                    l++;
                    if (l == r)
                    {
                        r++;
                    }
                }
                else if (pf[r] - pf[l] < B)
                {
                    r++;
                }
            }
            return ans;
        }
    }
}
