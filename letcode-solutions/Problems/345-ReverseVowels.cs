using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class ReverseVowelsSolution
    {
        public static string ReverseVowels(string s)
        {
            char[] result = s.ToCharArray();
            HashSet<char> chars = new HashSet<char>()
            {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
            };

            int i = 0;
            int j = s.Length - 1;

            while(i<j)
            {
                while(i<j && !chars.Contains(s[i]) )
                {
                    i++;
                }

                while (i < j && !chars.Contains(s[j]))
                {
                    j--;
                }

                char swap = s[i];
                char swap2 = s[j];
                result[i] = swap2;
                result[j] = swap;

                i++;
                j--;

            }

            return new string(result);
        }
    }
}
