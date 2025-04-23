using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        public bool ID_0009_IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x == 0) return true;
            List<int> encode = new List<int>();
            while (x > 0) 
            {
                encode.Add(x%10);
                x = x / 10;
            }
            encode.Reverse();

            int left = 0;
            int right = encode.Count - 1;

            while(left < right)
            {
                if (encode[left] == encode[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }    
            }

            return true;


        }
        public string ID_0014_Longest_Common_Prefix(string[] strs)
        {
            List<int> log = new List<int>();
            List<string> wordsList = strs.ToList();
            int max_length = wordsList.Min(x => x.Length);
            for (int i = 0; i < max_length; i++) 
            {
                char c = wordsList[0][i];
                bool same = true;
                for (int j = 1; j<wordsList.Count; j++)
                {
                    if (wordsList[j][i] == c) continue;
                    else same = false;
                }
                if (same)
                {
                    if (log.Count == 0) log.Add(1);
                    else log.Add(log[i - 1] + 1);
                }
                else
                    log.Add(0);
            }
            if (log.Count == 0) return "";
            int maxstring_length = log.Max();
            int index = log.IndexOf(maxstring_length);
            string longest_subwords = "";

            if (false)
            {
                for (int i = index - maxstring_length + 1; i <= index; i++)
                {
                    longest_subwords += wordsList[0][i].ToString();
                }
                return longest_subwords;
            }
            if(true)
            {
                for (int i = 0; i<log.Count; i++)
                {
                    if (log[i] != 0) { longest_subwords += wordsList[0][i]; }
                    else break;
                }
                return longest_subwords;
            }
        }
        public int ID_0028_Find_the_Index_of_the_First_Occurrence_in_a_String(string haystack, string needle)
        {
            if(needle.Length > haystack.Length) return -1;
            char head = needle[0];
            int sublength = needle.Length;

            List<int> logs = new List<int>();

            for (int i = 0; i < haystack.Length; i++) 
            {
                if (haystack[i] == head) logs.Add(i);
            }

            bool found = true;
            if (logs.Count == 0) return -1;
            for (int i = 0; i<logs.Count; i++)
            {
                found = true;
                for (int j = 0; j< sublength; j++)
                {
                    if (logs[i] + j >= haystack.Length) return -1;
                    if (haystack[logs[i]+j] == needle[j]) continue;
                    else
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return logs[i];
            }
            return -1;

        }
        public int ID_0035_SearchInsert(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            int m = (l + r) / 2;

            if (nums[0] >= target) return 0;
            if (nums[r] < target) return r + 1;
            if (m == 0) return 1;
            while(l < r)
            {
                if (l == m) return l + 1;
                if (nums[l] >= target) return l - 1;
                if (nums[r] <= target) return r + 1;

                if (nums[m] >= target & nums[m - 1] <target) return m;
                if (nums[m] < target)
                {
                    l = m;
                    m = (l + r) / 2;
                }
                if (nums[m] > target)
                {
                    r = m;
                    m = (l + r) / 2;
                }
            }

            return -1;
        }
        public int ID_0058_LengthOfLastWord(string s)
        {
            int l = s.Length - 1;
            int cnt = 0;
            bool scan = false;
            for (int i = l; i>=0; i--)
            {
                if (s[i] != ' ')
                {
                    if(scan == false) scan = true;
                    if(scan)cnt++;
                }
                else if(scan == true)
                {
                    return cnt;
                }
            }
            return cnt;
        }


    }


}
