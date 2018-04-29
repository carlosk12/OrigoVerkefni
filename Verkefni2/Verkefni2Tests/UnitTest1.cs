using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verkefni2;

namespace Verkefni2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFourCorrectInputs()
        {
            // Arrange
            string input = "one;two;three;four";
            string expected = "1234";

            // Act
            string result = Converter.ConvertToDigits(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFourIncorrectInputs()
        {
            // Arrange
            string input = "onee;ttwo;thrree;fouor";
            string expected = "";

            // Act
            string result = Converter.ConvertToDigits(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFourInputsButThreeAreCorrect()
        {
            // Arrange
            string input = "one;twwo;three;four";
            string expected = "134";

            // Act
            string result = Converter.ConvertToDigits(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
