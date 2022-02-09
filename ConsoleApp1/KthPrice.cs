using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class KthPrice
    {
        public int kthsmallest(List<int> A, int B)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            int l = min;
            int r = max;
            int ans = 0;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                int count = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] <= mid)
                    {
                        count++;
                    }
                }
                if (count >= B)
                {
                    ans = mid;
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return ans;
        }
    }
}
