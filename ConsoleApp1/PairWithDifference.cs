using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PairWithDifference
    {
        public int solve(List<int> A, int B)
        {
            A.Sort();
            int l = 0;
            int r = 1;
            B = Math.Abs(B);
            int count = 0;
            while (r < A.Count)
            {
                if ((A[r] - A[l]) == B)
                {
                    
                    int x = A[l];
                    while (l < A.Count && x == A[l])
                    {
                        l++;
                    }
                    int x1 = A[r];
                    while (r < A.Count && x1 == A[r])
                    {
                        r++;
                    }
                    count++;
                }
                else if ((A[r] - A[l]) < B)
                {
                    r++;
                }
                else if ((A[r] - A[l]) > B)
                {
                    l++;
                    if (l == r)
                    {
                        r++;
                    }
                }
            }
            return count;
        }
    }
}
