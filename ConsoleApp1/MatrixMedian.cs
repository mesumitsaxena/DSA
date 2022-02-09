using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MatrixMedian
    {
        public int BS(List<int> A, int mid)
        {
            int l = 0;
            int r = A.Count - 1;
            int count = 0;
            while (l <= r)
            {
                int middle = (l + r) / 2;
                if (A[middle] <= mid)
                {
                    count += (middle - l) + 1;
                    l = middle + 1;
                }
                else
                {
                    r = middle - 1;
                }
            }
            return count;
        }
        public bool check(List<List<int>> A, int mid, int median)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                count = count + BS(A[i], mid);
            }
            if (count >= median) return true;
            return false;

        }
        public int findMedian(List<List<int>> A)
        {
            int median = (1 + A.Count * A[0].Count) / 2;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int lastcol = A[0].Count - 1;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i][0] < min)
                {
                    min = A[i][0];
                }
                if (A[i][lastcol] > max)
                {
                    max = A[i][lastcol];
                }
            }
            int l = min;
            int r = max;
            int ans = 0;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (check(A, mid, median))
                {
                    ans = mid;
                    r = mid-1;
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
