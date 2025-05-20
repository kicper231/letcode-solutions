using letcode_solutions.Problems;

namespace Tests.tests
{
    public class KidsCandiesTests
    {
        [Theory]
        [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] { true, false, true })]
        public void KidsCandies_ReturnsCorrectResult(int[] candies, int extracandies, bool[] expected)
        {
            var result = KidsWithCandiesSolution.KidsWithCandies(candies, extracandies);
            Assert.Equal(expected, result.ToArray());
        }
    }
}