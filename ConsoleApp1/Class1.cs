using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public int divide(int A, int B)
        {
            if (B == 1) return A;
            long X = Math.Abs(A);
            long Y = Math.Abs(B);
            bool sign = false;
            if ((A > 0 && B > 0) || (A < 0 && B < 0))
            {
                sign = true;
            }
            long ans = 0;
            for (int i = 31; i >= 0; i--)
            {
                long val = Y * (1L << i);
                if (val <= X)
                {
                    ans = ans | (1L << i);
                    A = A - (int)val;
                }
            }
            if (sign == false)
            {
                ans = 0 - ans;
            }
            if (ans >= 2147483647) return 2147483647;
            return (int)ans;
        }
        public int strangequality(int A)
        {
            int x = 0; int y = 0;
            int pos = 0;
            for (int i = 0; i < 31; i++)
            {
                if ((A & (1 << i)) > 0)
                {
                    pos = i;
                }
            }
            y = y | (1 << (pos + 1));
            for (int j = pos; j >= 0; j--)
            {
                if ((A & (1 << j)) == 0)
                {
                    x = x | 1;
                }
            }
            return x ^ y;
        }

        public int BsFrequency(List<int> A)
        {
            int N = A.Count;
            if ((N - 1) == 1) return A[0];
            if (A[0] > A[1]) return A[0];
            if (A[N - 1] > A[N - 2]) return A[N - 1];
            int l = 1;
            int r = N - 2;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (A[mid] > A[mid - 1] && A[mid] > A[mid + 1])
                {
                    return A[mid];
                }
                else if (A[mid] > A[mid - 1] && A[mid] < A[mid + 1])
                {
                    l = mid + 1;
                }
                else if (A[mid] < A[mid - 1] && A[mid] > A[mid + 1])
                {
                    r = mid - 1;
                }
                else
                {
                    if (A[mid - 1] > A[mid + 1])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
            }
            return A[0];
        }
        public int sqrt(int A)
        {
            int l = 1;
            int r = Math.Min(A, 1000000000);
            long ans = 0;
            while (l <= r)
            {
                long mid = (l + r) / 2;
                if (mid * mid == A)
                {
                    return (int)mid;
                }
                if (mid * mid < A)
                {
                    ans = mid;
                    l = (int)(mid + 1);
                }
                else if (mid * mid > A)
                {
                    r = (int)(mid - 1);
                }
            }
            return (int)ans;
        }
        public bool CheckWindow(List<int> A, int B, int K)
        {
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                sum += A[i];
            }
            if (sum > B) return false;
            for (int j = K; j < A.Count; j++)
            {
                sum += A[j] - A[j - K];
                if (sum < B) return false;
            }
            return true;
        }
        public int solve(List<int> A, int B)
        {
            int l = 1;
            int r = A.Count;
            int ans = 0;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (CheckWindow(A, B, mid))
                {
                    ans = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return ans;
        }
        public int LCM(int a, int b)
        {
            int num1;
            int num2;
            if (a > b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;
                num2 = a;
            }
            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return (num1 * i);
                }
            }
            return num2;
        }
        public int Bitonic(List<int> A, int B)
        {
            int l = 0;
            int r = A.Count - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (A[mid] == B)
                {
                    return mid;
                }
                if (A[mid] > A[mid - 1])
                {
                    if (A[l] <= B && B < A[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                else if (A[mid] < A[mid - 1])
                {
                    if (A[mid] > B && A[r] <= B)
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
            }
            return -1;
        }
        public int divisors(int A, int B, int C)
        {
            int mod = 1000000007;
            long min = Math.Min(B, C);
            long l = min;
            long r = (min * A) % mod;
            long lcm = LCM(B, C);
            long ans = 0;
            while (l <= r)
            {
                long mid = l + (r - l) / 2;
                long x = (mid / B) + (mid / C) - (mid / lcm);
                if (x == A)
                {
                    ans = mid;
                    r = mid - 1;
                }
                else if (x < A)
                {
                    l = mid + 1;
                }
                else if (x > A)
                {
                    r = mid - 1;
                }

            }
            return (int)(ans % mod);
        }
        public List<int> solve(List<int> A)
        {
            int XOR = 0;
            for (int i = 0; i < A.Count; i++)
            {
                XOR = XOR ^ A[i];
            }
            int pos = -1;
            for (int i = 0; i < 32; i++)
            {
                int val = XOR & (1 << i);
                if (val >= 1)
                {
                    pos = i;
                    break;
                }
            }
            int XOR1 = 0;
            int XOR2 = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int val = A[i] & (1 << pos);
                if (val >= 1)
                {
                    XOR2 = XOR2 ^ A[i];
                }
                else
                {
                    XOR1 = XOR1 ^ A[i];
                }

            }
            List<int> output = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == XOR1)
                {
                    output.Add(XOR1);
                }
                else
                {
                    output.Add(XOR2);
                }
            }
            return output;
        }
    }
}
