using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Easy easy = new Easy();
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;

            var ans = easy.ID_0001_TwoSum(nums, target);
            Console.WriteLine(ans[0]);
            Console.WriteLine(ans[1]);

            Console.WriteLine();
        }
    }
}
