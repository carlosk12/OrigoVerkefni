using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni4
{
    public class Stack
    {
        private LinkedList<int> myStack;

        public Stack()
        {
            myStack = new LinkedList<int>();
        }

        //We add the newest value at the end of our linked list.
        public void Push(int Value)
        {
            myStack.AddLast(Value);
        }

        //Stacks are LIFO (Last In First Out) so when we pop we remove the last node added.
        public int Pop()
        {
            var poppedValue = myStack.Last;

            myStack.RemoveLast();

            return poppedValue.Value;
        }

        /* 
         * I divided the print every other function into two functions, one which you can call
         * when you want it printed to the console and another function which returns the string 
         * to be printed, that function is used by this print function.
         */        
        public void PrintEveryOtherValueAsString()
        {
            string stringToPrint;

            stringToPrint = EveryOtherValueAsString();

            Console.WriteLine(stringToPrint);
        }

        /* 
         * This function loops through the linked list and adds every other nodes value
         * to a string seperated by commas which is then returned. To know which ones to
         * print we use a boolean which rotates between true and false while passing through 
         * nodes. We also need a special case for when the stack is empty.
         */
        public string EveryOtherValueAsString()
        {
            bool printThis = false;
            string stringToPrint = "";
            var currentNode = myStack.First;

            if (myStack.Count == 0)
            {
                return "";
            }
            else
            {
                stringToPrint += currentNode.Value;

                currentNode = currentNode.Next;

                while (currentNode != null)
                {
                    if (printThis)
                    {
                        stringToPrint += ",";

                        stringToPrint += currentNode.Value;
                        
                    }

                    printThis = !printThis;
                    currentNode = currentNode.Next;
                }
            }

            return stringToPrint;
        }
    }
}
