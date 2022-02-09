using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreeSum
    {
        public List<List<int>> threeSum(List<int> A)
        {
            A.Sort();
            HashSet<string> hs = new HashSet<string>();
            List<List<int>> output = new List<List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                int sum = -1*A[i];
                int l = i + 1;
                int r = A.Count - 1;
                while (l < r)
                {
                    if (A[l] + A[r] == sum)
                    {

                        List<int> temp = new List<int>();
                        temp.Add(A[l]);
                        temp.Add(A[r]);
                        temp.Add(A[i]);
                        temp.Sort();
                        string combindedString = string.Join(",", temp.ToArray());
                        if (!hs.Contains(combindedString))
                        {
                            output.Add(temp);
                            hs.Add(combindedString);
                        }
                        l++;
                        r--;
                    }
                    else if (A[l] + A[r] > sum)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }
            return output;
        }
    }
}
