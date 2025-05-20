namespace letcode_solutions.Problems
{
    public class IncreasingTripletSolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }

            int first = int.MaxValue;
            int second = int.MaxValue;

            int i = 0;

            while (i < nums.Length)
            {
                if (nums[i] <= first)
                {
                    first = nums[i];
                }
                else if (nums[i] <= second)
                {
                    second = nums[i];
                }
                else
                {
                    return true;
                }

                i++;
            }

            return false;
        }
    }
}