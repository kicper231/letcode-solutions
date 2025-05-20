using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class FindMaxAverageSolution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double maxMean = sum / k;

            for (int i = k; i < nums.Length; i++)
            {
                sum -= nums[i - k];
                sum += nums[i];
                maxMean = Math.Max(sum / k, maxMean);
            }

            return maxMean;
        }
    }
}
