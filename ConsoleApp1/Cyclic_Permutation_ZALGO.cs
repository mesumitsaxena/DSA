using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cyclic_Permutation_ZALGO
    {

        public int solve(string A, string B)
        {
            string s = A + "$" + B + B;
            int n = A.Length;
            int m = s.Length;
            int[] z = new int[m];
            //List<int> z= new List<int>();
            //z.Add(s.Length);
            z[0] = s.Length;
            int l = 0;
            int r = 0;
            for (int i = 1; i < m; i++)
            {

                if (i > r)
                {
                    l = i;
                    r = i;
                    while (r < m && s[r] == s[r - l])
                    {
                        r++;
                    }

                    //z.Add(r-l-1);
                    z[i] = (r - l);
                    r--;
                }
                else
                {
                    if (z[i - l] < (r - i + 1))
                    {
                        //z.Add(z[i-l]);
                        z[i] = z[i - l];
                    }
                    else
                    {
                        l = i;
                        r++;
                        while (r < m && s[r] == s[r - l])
                        {
                            r++;
                        }

                        //z.Add(r-l+1);
                        z[i] = (r - l);
                        r--;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] == n)
                {
                    count++;
                }
            }
            if (z[z.Length - n] == n)
            {
                return count - 1;
            }
            return count;
        }


    }
}
