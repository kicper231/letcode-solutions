namespace letcode_solutions.Problems
{
    public class KidsWithCandiesSolution
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            return candies.Select(x => x + extraCandies >= candies.Max()).ToList();
        }
    }
}