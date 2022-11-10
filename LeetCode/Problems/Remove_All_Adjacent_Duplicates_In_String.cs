using System.Collections.Generic;
using System.Xml;

namespace LeetCode.Problems
{
    //1047. Remove All Adjacent Duplicates In String
    //Easy

    //You are given a string s consisting of lowercase English letters.A duplicate removal consists of choosing two adjacent and equal letters and removing them.

    //We repeatedly make duplicate removals on s until we no longer can.

    //Return the final string after all such duplicate removals have been made.It can be proven that the answer is unique.
    public class Remove_All_Adjacent_Duplicates_In_String
    {
        //Example 1:

        //Input: s = "abbaca"
        //Output: "ca"
        //Explanation: 
        //For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
        //Example 2:

        //Input: s = "azxxzy"
        //Output: "ay"
        public string RemoveDuplicates(string s)
        {
            List<char> result = new List<char>();
            for (int i = 0; i < s.Count(); i++)
            {
                if (i == 0)
                    result.Add(s[i]);
                else
                {
                    if (result.Count > 0)
                    {
                        //用result最後一位跟當前Index往前比對
                        for (int c = result.Count - 1; c >= 0; c--)
                        {
                            if (s.Length > i && result[c] == s[i])
                            {
                                result.RemoveAt(c);
                                if (result.Count > 0)
                                {
                                    i++;
                                }
                            }
                            else if(s.Length > i)
                            {
                                result.Add(s[i]);
                                break;
                            }
                        }
                    }
                    else
                    {
                        result.Add(s[i]);
                    }
                }
            }
           
            return new String(result.ToArray());
        }
    }
}
