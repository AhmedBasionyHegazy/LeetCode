using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkSpace
{
    public class Numbers
    {
        public bool isPalindRome(int n)
        {
            if (n < 0 || n % 10 == 0 && n != 0)
            {
                return false;
            }
            int reversedNum = 0;
            while (reversedNum < n)
            {
                int pop = n % 10;
                reversedNum = reversedNum * 10 + pop;
                n = n / 10;
            }
            return n == reversedNum || n == reversedNum / 10;
        }

        public int Trailing_zeros(int n)
        {
            int count = 0;
            if (n > 0)
            {
                n /= 5;
                count += n;
            }
            return count;
        }

        public double myPow(double x, int n)
        {
            double ans = 1.0;
            long num = n;
            if (num < 0)
            {
                num *= -1;
            }
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    x *= x;
                    num /= 2;
                }
                else
                {
                    ans *= x;
                    num -= 1;
                }
            }
            if (n < 0)
            {
                return (double)1.0 / (double)ans;
            }
            return ans;
        }
    }
}
