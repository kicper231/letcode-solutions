using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class UniqueOccurrencesSolution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            if(arr.Length == 1) return true;

            var dict = arr.GroupBy(x => x).ToDictionary(x=>x.Key, x=>x.Count());
            
            var hashSet = new HashSet<int>(dict.Values);

            return hashSet.Count == dict.Count;
        }
    }
}
