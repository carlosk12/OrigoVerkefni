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
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "ndboltiha");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestFalseResult()
        {
            // Arrange
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "ndboltihi");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestShorterSecondInput()
        {
            // Arrange
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "ndboltih");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestLongerSecondInput()
        {
            // Arrange
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "ndboltihaa");

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestDifferentRotationIsTrue()
        {            
            // Arrange
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "boltihand");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestDifferentRotationIsFalse()
        {
            // Arrange
            MyString MyStringVar = new MyString();

            // Act
            bool result = MyStringVar.IsRotated("handbolti", "boltihind");

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
