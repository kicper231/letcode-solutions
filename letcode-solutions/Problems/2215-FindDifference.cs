using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class FindDifferenceSolution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var hash1 = nums1.ToHashSet();
            var hash2 = nums2.ToHashSet();
            var copy1 = nums1.ToHashSet();

            IList<int> result1 = new List<int>();
            IList<int> result2 = new List<int>();
            hash1.RemoveWhere(x => hash2.Contains(x));
            hash2.RemoveWhere(x => copy1.Contains(x));

            result1 = hash1.ToList();
            result2 = hash2.ToList();   


            return new List<IList<int>>() { result1, result2 };


        }
    }
}
