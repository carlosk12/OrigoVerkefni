using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni3
{
    public static class ReverseString
    {
        //This function takes in a variable which is referenced by value
        public static void Reverse(ref char[] originalInput)
        {
            /* 
             * We create a placeholder for when we switch the characters and a backwards counter for the loop
             * since we need to know two locations at once, starting at each end of the array.
             */
            char letterHolder;
            int backwardsCounter = originalInput.Length - 1;

            /* 
             * We start at the beginning of the array, place the character there in our placeholder, place the
             * last character in the array in the first index, change our counters and then we change the next to indexes
             * moving closer to the middle of the array.
             */
            for (int forwardCounter = 0; forwardCounter < (originalInput.Length / 2); forwardCounter++, backwardsCounter--)
            {
                letterHolder = originalInput[forwardCounter];

                originalInput[forwardCounter] = originalInput[backwardsCounter];

                originalInput[backwardsCounter] = letterHolder;
            }
        }

        public static void PrintCharArray(char[] originalInput)
        {
            for (int i = 0; i < originalInput.Length; i++)
            {
                Console.Write(originalInput[i]);
            }
        }
    }
}
