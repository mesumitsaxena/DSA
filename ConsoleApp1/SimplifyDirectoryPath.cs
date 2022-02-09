using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SimplifyDirectoryPath
    {

        public string reverse(List<string> sb)
        {
            StringBuilder sb2 = new StringBuilder();
            if (sb.Count == 0) sb2.Append("/");
            for(int i=sb.Count-1; i>=0; i--)
            {
                sb2.Append("/");
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
        public string simplifyPath(string A)
        {
            Stack<string> stack = new Stack<string>();
            int i = 1;
            while (i < A.Length)
            {
                System.Text.StringBuilder sb= new System.Text.StringBuilder();
                while (i < A.Length && A[i] != '/')
                {
                    sb.Append(A[i]);
                    i++;
                }
                string s = sb.ToString();
                if (stack.Count > 0 && s == "..")
                {
                    stack.Pop();
                }
                else if (s!="" && s!=".." && s != "." && s != "/")
                {
                    stack.Push(s);
                }
                i++;
            }
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
            List<string> list = new List<string>();
            while(stack.Count > 0)
            {
                list.Add(stack.Pop());
            }
            string output = reverse(list);
            return output;

        }
    }
}
