namespace letcode_solutions.Problems
{
    public class SolutionMoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int zeroCount = nums.Count(x => x == 0);
            var list = nums.ToList();
            list.RemoveAll(x => x == 0);
            list.AddRange(Enumerable.Repeat(0, zeroCount));

            nums = list.ToArray();
        }
    }
}