using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verkefni4;

namespace Verkefni4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZeroPush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "";

            // Act
            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TestOnePush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "2";

            // Act
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TestTwoPush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "4";

            // Act
            myStack.Push(4);
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TestThree()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "1,2";

            // Act
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }


        [TestMethod]
        public void TestFourPush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "7,4";

            // Act
            myStack.Push(7);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TestEvenAmountOfPush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "3,7,4";

            // Act
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TestUnevenAmountOfPush()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResult;
            string expectedResult = "5,1,2";

            // Act
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResult = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResult, obtainedResult);
        }

        [TestMethod]
        public void TesEvenAmountOfPushWithPop()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResultPrePop;
            string obtainedResultPostPop;
            string expectedResultPrePop = "3,7,4";
            string expectedResultPostPop = "3,7,4";

            // Act
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResultPrePop = myStack.EveryOtherValueAsString();

            myStack.Pop();

            obtainedResultPostPop = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResultPrePop, obtainedResultPrePop);
            Assert.AreEqual(expectedResultPostPop, obtainedResultPostPop);
        }

        [TestMethod]
        public void TestUnevenAmountOfPushWithPop()
        {
            // Arrange
            Stack myStack = new Stack();
            string obtainedResultPrePop;
            string obtainedResultPostPop;
            string expectedResultPrePop = "5,1,2";
            string expectedResultPostPop = "5,1";

            // Act
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            obtainedResultPrePop = myStack.EveryOtherValueAsString();

            myStack.Pop();

            obtainedResultPostPop = myStack.EveryOtherValueAsString();

            // Assert
            Assert.AreEqual(expectedResultPrePop, obtainedResultPrePop);
            Assert.AreEqual(expectedResultPostPop, obtainedResultPostPop);
        }
    }
}
