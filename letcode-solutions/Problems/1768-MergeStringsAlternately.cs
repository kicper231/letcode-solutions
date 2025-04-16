using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.problems
{
    public class MergeAlternatelySolution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder builder = new StringBuilder();
            int length1 = word1.Length;
            int length2 = word2.Length;
            int maxLength = Math.Max(length1, length2);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < length1) builder.Append(word1[i]);
                if (i < length2) builder.Append(word2[i]);
            }

            return builder.ToString();
        }
    }
}
