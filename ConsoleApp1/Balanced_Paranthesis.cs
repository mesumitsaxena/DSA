using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Balanced_Paranthesis
    {

        public bool checkopeningbracket(char A)
        {
            StringBuilder sb = new StringBuilder();
            if (A == '{' || A == '[' || A == '(')
            {
                return true;
            }
            return false;
        }
        public char getopeningbracket(char A)
        {
            switch (A)
            {
                case '}': return '{';
                case ')': return '(';
                case ']': return '[';
                default: return '0';
            }
        }
        public int solve(string A)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (checkopeningbracket(A[i]))
                {
                    s.Push(A[i]);
                }
                else
                {
                    char val = getopeningbracket(A[i]);
                    if (s.Count>0 && val == s.Peek())
                    {
                        s.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            char[] obj = s.ToArray();
            if (s.Count > 0) return 0;
            return 1;
        }
    }
}
