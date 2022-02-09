using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LargestContinuousZeroSum
    {
            
        public List<int> lszero(List<int> A)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();
            hm.Add(0, -1);
            hm.Add(A[0], 0);
            int val = A[0];
            int ans = Int32.MinValue;
            List<int> output = new List<int>();
            int l = 0;
            int r = 0;
            for (int i = 1; i < A.Count; i++)
            {
                val += A[i];
                if (hm.ContainsKey(val))
                {
                    int dist = i - hm[val];
                    if (dist > ans)
                    {
                        l = hm[val] + 1;
                        r = i;
                        ans = dist;
                    }
                }
                else
                {
                    hm.Add(val, i);
                }
            }
            for (int i = l; i <= r; i++)
            {
                output.Add(A[i]);
            }
            return output;
        }
    }
}
