using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verkefni3;

namespace Verkefni3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUnevenLength()
        {
            // Arrange
            char[] input = { 'P', 'A', 'L', 'L', 'I' };
            char[] expected = {'I', 'L', 'L', 'A', 'P'};

            // Act
            ReverseString.Reverse(ref input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestEvenLength()
        {
            // Arrange
            char[] input = { 'P', 'A', 'L', 'L', 'A', 'R' };
            char[] expected = { 'R', 'A', 'L', 'L', 'A', 'P' };

            // Act
            ReverseString.Reverse(ref input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestStringToChar()
        {
            // Arrange
            char[] input;
            char[] expected = { 's', 'k', 'r', 'o', 'w', ' ',
                                't', 's', 'e', 't', ' ',
                                's', 'i', 'h', 'T' };

            // Act
            input = "This test works".ToCharArray();
            ReverseString.Reverse(ref input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
