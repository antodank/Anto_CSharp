using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringBuildLibrary; 

namespace StringBuildTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void combineStringArrayToLinew_WithEmptyArray()
        {
            //Arrange
            clsStringBuild objstring = new clsStringBuild();
            string[] input = new string[] { };
            string expected = string.Empty;

            //Act
            string actual = objstring.combineStringArrayToLine(input);

            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify input string array.");

        }

        [TestMethod]
        public void combineStringArrayToLinew_WithEmptySpace()
        {
            clsStringBuild objstring = new clsStringBuild();
            string[] input = new string[] {"This", "is","  ", "my", "first", "unit", "Test" };
            string expected = "This is my first unit Test";

            string actual = objstring.combineStringArrayToLine(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void combineStringArrayToLinew_WithSpace()
        {
            clsStringBuild objstring = new clsStringBuild();
            string[] input = new string[] { "This", " is ","my", "first", "unit","Test" };
            string expected = "This is my first unit Test";

            string actual = objstring.combineStringArrayToLine(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void combineStringArrayToLinew_WithNoSpace()
        {
            clsStringBuild objstring = new clsStringBuild();
            string[] input = new string[] { "This", "is", "my","first", "unit", "Test" };
            string expected = "This is my first unit Test";

            string actual = objstring.combineStringArrayToLine(input);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
