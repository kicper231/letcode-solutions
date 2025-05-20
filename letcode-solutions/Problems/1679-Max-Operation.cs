using System.Reflection.Metadata.Ecma335;

namespace letcode_solutions.Problems
{
    public class MaxOperationsSolution
    {
        public int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && dict.ContainsKey(k - nums[i])
                    && dict[nums[i]]>0 && dict[k - nums[i]]>0)
                {
                    int min = Math.Min(dict[nums[i]], dict[k - nums[i]]);
                    result += min;

                    dict[nums[i]] -= min;
                    dict[k-nums[i]] -= min;
                }


            }

            return result;
        }
    }
}