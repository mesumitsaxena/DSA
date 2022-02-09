using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BS_PainterTime
    {
        public bool CheckPainterUnitHours(List<int> C,int A,int B, long mid)
        {
            long counthours = C[0] * B;
            int worker = 1;
            for(int i = 1; i < C.Count; i++)
            {
                if(counthours+C[i]*B > mid)
                {
                    worker++;
                    counthours = C[i] * B;
                }
                else
                {
                    counthours += C[i] * B;
                }
            }
            if (worker <= A) return true;
            return false;
        }
        public int paint(int A, int B, List<int> C)
        {
            long totalsum = 0;
            long max = Int32.MinValue;
            for (int i = 0; i < C.Count; i++)
            {
                totalsum += C[i];
                if (max < C[i])
                {
                    max = C[i];
                }
            }
            long l = max * B;
            long r = totalsum * B;
            if (A == 1) return (int)(r % 10000003);
            long ans = 0;
            while (l <= r)
            {
                long mid=(l+r)/2;
                if (CheckPainterUnitHours(C, A, B, mid))
                {
                    ans = mid;
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return (int)(ans % 10000003);
        }
    }
}
