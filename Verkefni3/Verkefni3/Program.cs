using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] originalInput;

            //We read the users input and convert it to a char array
            Console.WriteLine("Please insert the string to reverse: ");
            originalInput = Console.ReadLine().ToCharArray();

            ReverseString.Reverse(ref originalInput);

            Console.WriteLine("Reversed input is: ");

            ReverseString.PrintCharArray(originalInput);

            Console.ReadLine();
        }
    }
}
