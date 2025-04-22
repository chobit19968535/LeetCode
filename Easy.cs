using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Easy
    {
        public int[] ID_0001_TwoSum(int[] nums, int target)
        {
            int[] ans;
            Dictionary<int, int> pair = new Dictionary<int, int>();
            Dictionary<int, int> log = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            { 
                int value = target - nums[i];
                int key = nums[i];

                if (pair.ContainsKey(value))
                {
                    ans = new int[2] { log[value], i };
                    return ans;
                }
                else
                {
                    if (pair.ContainsKey(key)) continue;
                    pair.Add(key, value);
                    log.Add(key, i);
                }

            }
            ans = new int[2] { -1, -1};
            return ans;

        }
    }
}
