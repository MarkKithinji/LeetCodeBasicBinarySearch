using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeVeryBasicBinarySearch
{
    internal class SearchForTarget
    {
        public int search(int[] nums, int target)
        {
            Array.Sort(nums);
            int min = 0;
            int max = nums.Length - 1;

            if (target == null || nums.Length == 0 ) { return -1; }

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if(target < nums[mid])
                {
                    max= mid - 1;
                }
                else { min= mid + 1; }
            }
            return -1;
        }
    }
}
