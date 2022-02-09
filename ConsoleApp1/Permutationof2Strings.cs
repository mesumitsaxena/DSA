using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Permutationof2Strings
    {
        public int solve(string A, string B)
        {
            Dictionary<char, int> hm = new Dictionary<char, int>();
            int ans = A.Length;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (hm.ContainsKey(A[i]))
                {
                    hm[A[i]]++;
                }
                else
                {
                    hm.Add(A[i], 1);
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (hm.ContainsKey(B[i]))
                {

                    hm[B[i]]--;
                    if (hm[B[i]] >= 0)
                    {
                        ans--;
                    }
                }
            }
            if (ans == 0) count++;
            for (int j = A.Length; j < B.Length; j++)
            {
                char rem = B[j - A.Length];
                if (hm.ContainsKey(rem))
                {
                    
                    if (hm[rem] >= 0)
                    {

                        ans++;
                    
                    }
                    hm[rem]++;
                }
                char adding = B[j];
                if (hm.ContainsKey(adding))
                {
                    hm[adding]--;
                    if (hm[adding] >= 0)
                    {
                        ans--;
                    }
                }
                if (ans == 0) count++;
            }
            return count;
        }
    }
}
