using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SubarraySumWithPair_2Pointer
    {
        public List<int> solve(List<int> A, int B)
        {
            int l = 0;
            int r = A.Count - 1;
            List<int> ans = new List<int>() { -1 };
            while (l < r)
            {
                if (A[l] + A[r] == B)
                {
                    ans = new List<int>();
                    ans.Add(l + 1);
                    ans.Add(r - 1);
                    l++;
                    r--;
                }
                else if (A[l] + A[r] > B)
                {
                    r--;
                }
                else if (A[l] + A[r] < B)
                {
                    l++;
                }
            }
            return ans;
        }
    }
}
