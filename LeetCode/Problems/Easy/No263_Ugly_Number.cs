using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Easy
{
    //An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

    //Given an integer n, return true if n is an ugly number.
    public class No263_Ugly_Number
    {
        public bool IsUgly(int n)
        {
            if (n == 1)
                return true;

            if (n <= 0)
                return false;

            while (n % 2 == 0)
            {
                n = n / 2;
            }

            while (n % 3 == 0)
            {
                n = n / 3;
            }

            while (n % 5 == 0)
            {
                n = n / 5;
            }

            return n == 1;
        }
    }
}
