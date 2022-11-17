using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Easy
{
    public class No26_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            Console.WriteLine("RemoveDuplicates");
            Console.WriteLine(string.Join(",", nums));
            int tmp = nums[0];
            int cnt = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > tmp)
                {
                    tmp = nums[i];
                    nums[cnt] = tmp;
                    cnt++;
                }
            }

            Console.WriteLine(string.Join(",", nums));
            return cnt;
        }

        public int RemoveDuplicates_O(int[] nums)
        {
            Console.WriteLine("RemoveDuplicates_O");
            Console.WriteLine(string.Join(",", nums));
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }

            int count = 1, temp = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != temp)
                {
                    temp = nums[i];
                    nums[count] = temp;
                    count++;
                }
            }

            Console.WriteLine(string.Join(",", nums));

            return count;
        }
    }
}
