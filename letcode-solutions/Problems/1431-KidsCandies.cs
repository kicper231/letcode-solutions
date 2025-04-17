using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
