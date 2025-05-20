using System.Text.RegularExpressions;

namespace letcode_solutions.Problems
{
    public class ReverseWordsSolution
    {
        public static string ReverseWords(string s)
        {
            s = s.Trim();
            s = Regex.Replace(s, @"\s+", " ");
            string[] splitresult = s.Split(' ');
            splitresult = splitresult.Reverse().ToArray();
            return string.Join(" ", splitresult);
        }
    }
}