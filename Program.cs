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
            if (false)
            {
                int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
                int target = 11;

                var ans_0001 = easy.ID_0001_TwoSum(nums, target);
                Console.WriteLine(ans_0001[0]);
                Console.WriteLine(ans_0001[1]);
            }
            if(false)
            {
                var ans_0009 = easy.ID_0009_IsPalindrome(11);
                Console.WriteLine(ans_0009);
                Console.WriteLine();
            }

            if(true)
            {
                List<string> words = new List<string>() { "flower", "fkow" };
                var ans_0014 = easy.ID_0014_Longest_Common_Prefix(words.ToArray());
                Console.WriteLine(ans_0014);
                Console.WriteLine();
            }

        }
    }
}
