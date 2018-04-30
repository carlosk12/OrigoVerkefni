using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verkefni1;

namespace Verkefni1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrueResult()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = MyString.IsRotated("handbolti", "ndboltiha");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFalseResult()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = MyString.IsRotated("handbolti", "ndboltihi");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestShorterSecondInput()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = MyString.IsRotated("handbolti", "ndboltih");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLongerSecondInput()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = MyString.IsRotated("handbolti", "ndboltihaa");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDifferentRotationIsTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = MyString.IsRotated("handbolti", "boltihand");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDifferentRotationIsFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = MyString.IsRotated("handbolti", "boltihind");

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
