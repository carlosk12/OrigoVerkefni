using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni2
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalInput;
            string resultString;

            //Input read as a whole
            Console.WriteLine("Please input numbers seperated with a semicolon to turn them into digits: ");
            originalInput = Console.ReadLine();

            /* 
             * Send the original input as a whole into the class, class will then take care of splitting the 
             * numbers, converting them and will return the answer as a single string 
             */
            resultString = Converter.ConvertToDigits(originalInput);

            Console.WriteLine("Converted result is: " + resultString);

            Console.ReadLine();
        }
    }
}
