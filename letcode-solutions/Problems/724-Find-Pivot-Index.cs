using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class PivotIndexSolution
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int left = 0;

            int sum = nums.Sum() - nums[0];

            if (left == sum)
            { return 0; }

            for (int i = 1; i < nums.Length; i++)
            {
                left = left + nums[i - 1];
                sum -= nums[i];

                if (left == sum)
                    return i;
            }

            return -1;
        }
    }
}