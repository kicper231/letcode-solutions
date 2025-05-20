using letcode_solutions.Problems;

namespace Tests.Tests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        public void ReverseWords_Basic(string s, string expected)
        {
            var result = ReverseWordsSolution.ReverseWords(s);
            Assert.Equal(expected, result);
        }
    }
}