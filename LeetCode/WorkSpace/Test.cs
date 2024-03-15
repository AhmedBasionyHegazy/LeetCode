using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkSpace
{
    public class Test
    {
        public int First_non_repeating_index(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;
            List<char> list = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        list.Add(s[i]);
                        break;
                    }
                }
                if (!list.Exists(x => x == s[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public string Longet_palindrome_string(string[] s)
        {
            if (s is null) return "-1";
            int maxIndex = 0;
            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (is_palindrome(s[i]) && s[i].Length > maxLength)
                {
                    maxIndex = i;
                    maxLength = s[i].Length;
                }
            }
            if (maxLength > 0)
            {
                return s[maxIndex];
            }
            return "-1";
        }

        private bool is_palindrome(string s)
        {
            if (s is null) return false;
            //int endIndex = s.Length - 1;
            //s = s.Trim();
            s = s.ToLower();
            s = string.Join("", s.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            int endIndex = s.Length - 1;
            for (int i = 0; i < endIndex; i++)
            {
                //h:
                //    if (s[i] == ' ')
                //    {
                //        i++;
                //        goto h;
                //    }
                //y:
                //    if (s[endIndex] == ' ')
                //    {
                //        endIndex--;
                //        goto y;
                //    }
                if (s[i] != s[endIndex])
                {
                    return false;
                }
                endIndex--;
            }
            return true;
        }

        public string GetSum(int num)
        {
            if (num <= 0) return "";
            int sum = 0;
            List<int> nums=new List<int>();
            while (num > 0)
            {
                nums.Insert(0,num % 10);
                sum += num % 10;
                num /= 10;
            }
            return string.Format($"{string.Join(" + ", nums)} = {sum}");
        }
    }
}
