using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using letcode_solutions.problems;
using letcode_solutions.Problems;
using Xunit;


namespace Tests.tests
{
    public class KidsCandiesTests
    {
        [Theory]
        [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] {true, false, true })]
        public void KidsCandies_ReturnsCorrectResult(int[] candies, int extracandies, bool[] expected)
        {
            var result = KidsWithCandiesSolution.KidsWithCandies(candies, extracandies);
            Assert.Equal(expected, result.ToArray());
        }
    }
}