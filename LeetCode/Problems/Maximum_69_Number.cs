using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //1323. Maximum 69 Number
    //Easy

    //You are given a positive integer consisting only of digits and.num69

    //Return the maximum number you can get by changing at most one digit(becomes , and becomes).6996
    internal class Maximum_69_Number
    {
        //Example 1:

        //Input: num = 9669
        //Output: 9969
        //Explanation: 
        //Changing the first digit results in 6669.
        //Changing the second digit results in 9969.
        //Changing the third digit results in 9699.
        //Changing the fourth digit results in 9666.
        //The maximum number is 9969.
        //Example 2:

        //Input: num = 9996
        //Output: 9999
        //Explanation: Changing the last digit 6 to 9 results in the maximum number.
        //Example 3:

        //Input: num = 9999
        //Output: 9999
        //Explanation: It is better not to apply any change.
        public static int Maximum69Number(int num)
        {
            char[] sNum = num.ToString().ToCharArray();
            for (int i = 0; i < sNum.Length; i++)
            {
                if (sNum[i] == '6')
                {
                    sNum[i] = '9';
                    break;
                }
            }

            return Convert.ToInt32(new string(sNum));
        }
    }
}
