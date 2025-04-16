using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using letcode_solutions.problems;
using Xunit;


namespace Tests.tests
{
    public class MergeAlternatelySolutionTests
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("abc", "aa", "apbaa")]
        public void MergeAlternately_ReturnsCorrectResult(string a, string b, string expected)
        {
            var result = MergeAlternatelySolution.MergeAlternately(a, b);
            Assert.Equal(expected, result);
        }
    }
}
