using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni1
{
    public class MyString
    {
        /* 
         * This function searches in the original string for the location of the first two characters in the rotated 
         * string. If it doesn't find a match it will return -1
         * */
        private int FindWhereRotationStarts(string originalString, string rotatedString)
        {
            for (int i = 0; i < rotatedString.Length - 1; i++)
            {
                if (originalString[i] == rotatedString[0] && originalString[i + 1] == rotatedString[1])
                {
                    return i;
                }
            }

            return -1;
        }

        //This is the function we call in the program
        public bool IsRotated(string originalString, string rotatedString)
        {
            int rotationLoc = FindWhereRotationStarts(originalString, rotatedString);

            //If FindWhereRotationStarts returns -1 then the strings dont match and we return false
            if(rotationLoc == -1)
            {
                return false;
            }

             // We check if the original string contains the "unrotated part" of the rotated string
            if (originalString.Contains(rotatedString.Substring(0, rotatedString.Length - rotationLoc)))
            {
                /*
                 * The "unrotated part" of the rotated string could be the same but we still need to check if the "rotated part"
                 * of the rotation string matches the original string.
                 */
                if (originalString.Substring(0, rotationLoc) == rotatedString.Substring(rotatedString.Length - rotationLoc, rotationLoc))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
