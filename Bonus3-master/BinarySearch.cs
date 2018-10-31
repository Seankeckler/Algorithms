using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class BinarySearch : Guesser
    {
        public override int Guess()
        {

            return 1;

        }



        public int Guess(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                
                return 1;
                
            }
            else
            {
                guessCount++;
                int mid = (min + max) / 2;
               
                if (key == mid)
                {
                    guessCount = guessCount - 100;
                    return mid;
                    
                }
                else if (key < mid)
                {
                    return Guess(inputArray, key, min, mid - 1);
                }
                else
                {
                    return Guess(inputArray, key, mid + 1, max);
                }
                
            }
            
        }

    }
}
