using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcode_solutions.Problems
{
    public class CanPlaceFlowersSolution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int counter = 0;
           

            for(int i=0;i<flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    counter++;
                    if(i == 0)
                    {
                        counter++;
                    }

                    if(i == flowerbed.Length-1)
                    {
                        counter++;
                        n -= (counter - 1) / 2;
                    }
                }
                
                if(flowerbed[i] == 1)
                {

                    n -= (counter - 1) / 2; 
                    counter = 0;
                }
            }


            return  n <= 0;
        }
    }
}
