using letcode_solutions.problems;

namespace Tests.tests
{
    public class MergeAlternatelySolutionTests
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("abc", "aa", "aabac")]
        public void MergeAlternately_ReturnsCorrectResult(string a, string b, string expected)
        {
            var result = MergeAlternatelySolution.MergeAlternately(a, b);
            Assert.Equal(expected, result);
        }
    }
}