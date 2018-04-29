using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni2
{
    public static class Converter
    {
        //Function called by main program, it uses three helper functions to process the original input.
        public static string ConvertToDigits(string originalString)
        {
            string[] inputInArray;
            string convertedString = "";

            inputInArray = SplitInput(originalString);

            convertedString = CombineDigits(inputInArray);

            return convertedString;
        }

        //Split original input so that the class can process each number
        private static string[] SplitInput(string originalString)
        {
            return originalString.Split(';');
        }

        //I feel like a switch case would be best here to check each number seperately and convert it to a digit
        private static string ConvertSingleToDigit(string number)
        {
            switch (number)
            {
                case "zero":
                    return "0";
                case "one":
                    return "1";
                case "two":
                    return "2";
                case "three":
                    return "3";
                case "four":
                    return "4";
                case "five":
                    return "5";
                case "six":
                    return "6";
                case "seven":
                    return "7";
                case "eight":
                    return "8";
                case "nine":
                    return "9";

                default:
                    return "";
            }
        }

        //This helper function uses another helper function to help keep the code modular
        private static string CombineDigits(string[] inputInArray)
        {
            var convertedString = "";

            for (int i = 0; i < inputInArray.Length; i++)
            {
                var convertedNumber = ConvertSingleToDigit(inputInArray[i]);
                convertedString += convertedNumber;
            }

            return convertedString;
        }
    }
}
