using System;

namespace Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsSubsequence("cart", "caerkit"));
        }
        static bool IsSubsequence(string s1, string s2)
        {
            for (int i = 0; i <= s2.Length - 1; i++)
            {
                if (s1[0] == s2[i])
                {
                    s1 = s1.Remove(0, 1);
                    s2 = s2.Remove(0, i + 1);
                    if (s1.Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return IsSubsequence(s1, s2);
                    }
                }
            }
            if (s1.Length != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

