using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //1544. Make The String Great
    //Easy
    //Given a string s of lower and upper case English letters.

    //A good string is a string which doesn't have two adjacent characters s[i] and s[i + 1] where:

    //0 <= i <= s.length - 2
    //s[i] is a lower-case letter and s[i + 1] is the same letter but in upper-case or vice-versa.
    //To make the string good, you can choose two adjacent characters that make the string bad and remove them.You can keep doing this until the string becomes good.

    //Return the string after making it good.The answer is guaranteed to be unique under the given constraints.

    //Notice that an empty string is also good.

    //Example 1:

    //Input: s = "leEeetcode"
    //Output: "leetcode"
    //Explanation: In the first step, either you choose i = 1 or i = 2, both will result "leEeetcode" to be reduced to "leetcode".
    //Example 2:

    //Input: s = "abBAcC"
    //Output: ""
    //Explanation: We have many possible scenarios, and all lead to the same answer.For example:
    //"abBAcC" --> "aAcC" --> "cC" --> ""
    //"abBAcC" --> "abBA" --> "aA" --> ""
    //Example 3:

    //Input: s = "s"
    //Output: "s"
    public class Make_The_String_Great
    {
        public string MakeGood(string s)
        {
            while (s.Length > 1)
            {
                bool find = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.Length > i + 1 && (s[i] ^ s[i + 1]) == 32)//大小寫 ^ 32
                    {
                        s = s.Remove(i, 2);
                        find = true;
                    }
                }
                if (find == false)
                {
                    break;
                }
            }

            return s;
        }

        /// <summary>
        /// 原做法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MakeGood_Ori(string s)
        {
            if (s.Length == 1)
                return s;

            while (SearchTwoAdjacent_Ori(s, out string c))
            {
                s = s.Replace(c, "");
            }
            return s;
        }

        public bool SearchTwoAdjacent_Ori(string s, out string r)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length > i + 1)
                {
                    if (CheckTwoAdjacent(s[i].ToString(), s[i + 1].ToString()))
                    {
                        r = s[i] + s[i + 1].ToString();
                        return true;
                    }
                }
            }
            r = "";
            return false;
        }

        public bool CheckTwoAdjacent(string s1, string s2)
        {
            if (s1.ToLower() == s2.ToLower() &&
               (s1 + s2 == s1.ToUpper() + s2.ToLower() || s1 + s2 == s1.ToLower() + s2.ToUpper())
            )
            {
                return true;
            }
            return false;
        }
    }
}
