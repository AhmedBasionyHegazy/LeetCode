using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkSpace
{
    public class Strings
    {
        public char[] reveseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            return s;
        }

        public string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];
            for (int i = 1; i < strs.Length - 1; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }

        public string reverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            int i = s.Length - 1;
            while (i >= 0)
            {
                if (s[i] == ' ')
                {
                    i--;
                }
                else
                {
                    int j = i;
                    while (i >= 0 && s[i] != ' ')
                    {
                        i--;
                    }
                    if (sb.Length > 0)
                    {
                        sb.Append(' ');
                    }
                    for (int k = i + 1; k <= j; k++)
                    {
                        sb.Append(s[k]);
                    }
                }
            }
            return sb.ToString();
        }

        public string longestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, (end + 1) - start);
        }

        private int expandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        public int lengthOfLongestSubstring(string s)
        {
            List<char> chars = new List<char>();
            int l = 0;
            int res = 0;
            for (int r=0; r < s.Length; r++) 
            {
                while (chars.Contains(s[r]))
                {
                    chars.Remove(s[l]);
                    l++;
                }
                chars.Add(s[r]);
                res = Math.Max(res, r - l + 1);
            }
            return res;
        }
    }
}
