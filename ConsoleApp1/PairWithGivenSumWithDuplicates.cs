using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PairWithGivenSumWithDuplicates
    {
        public int solve(List<int> A, int B)
        {
            int mod = 1000000007;
            int l = 0;
            int r = A.Count - 1;
            long ans = 0;
            while (l < r)
            {
                if (A[l] + A[r] == B)
                {
                    if (A[l] == A[r])
                    {
                        int count = r - l + 1;
                        ans += 1L * ((count * (count - 1)) / 2);
                        l++;
                        r--;
                    }
                    else
                    {
                        int count0 = 0;
                        int x = A[l];
                        while (l <= r && x == A[l])
                        {
                            count0++;
                            l++;
                        }
                        int count1 = 0;
                        int x1 = A[r];
                        while (l <= r && x1 == A[r])
                        {
                            count1++;
                            r--;
                        }
                        ans += 1L * (count0 * count1);
                    }
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
            return (int)(ans % mod);
        }
    }
}
