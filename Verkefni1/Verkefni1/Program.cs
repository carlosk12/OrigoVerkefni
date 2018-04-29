using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString();
            string input;
            string originalString;
            string rotatedString;
            bool isRotatedResult = false;

            Console.WriteLine("Please input strings seperated with a comma to check if isRotated: ");
            //Input read as a whole
            input = Console.ReadLine();

            //Input divided into the two words to be used
            originalString = input.Split(',')[0];
            rotatedString = input.Split(',')[1].TrimStart(' ');

            Console.WriteLine("Your first input is: " + originalString);
            Console.WriteLine("Your second input is: " + rotatedString);

            isRotatedResult = myString.IsRotated(originalString, rotatedString);
            Console.WriteLine("Is the second input a rotated version of the first input: " + isRotatedResult);

            Console.ReadLine();
        }
    }
}
