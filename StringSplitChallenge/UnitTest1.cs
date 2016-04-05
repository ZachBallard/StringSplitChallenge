using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSplitChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            Assert.AreEqual("Daniel", FirstName("Daniel Pollock"));
        }

        private string FirstName(string v)
        {
            var nameArray = v.Split(' ');
            var fullName = nameArray[0];

            if (nameArray.Length <= 2)
            {
                return nameArray[0];
            }

            for (int i = 1; i < nameArray.Length-1; i++)
            {
                fullName = fullName + ' ' + nameArray[i];
            }
            return fullName;
        }

        [TestMethod]
        public void TestLastName()
        {
            Assert.AreEqual("Pollock", LastName("Daniel Pollock"));
        }

        private string LastName(string v)
        {
            var nameArray = v.Split(' ');

            int i = nameArray.Length - 1;

            return nameArray[i];
        }

        [TestMethod]
        public void TestOneWordName()
        {
            Assert.AreEqual("Moby", FirstName("Moby"));
            Assert.AreEqual("Moby", LastName("Moby"));
        }



        [TestMethod]
        public void TestThreeWordName()
        {
            Assert.AreEqual("John Quincy", FirstName("John Quincy Adams"));
            Assert.AreEqual("Adams", LastName("John Quincy Adams"));
        }

        [TestMethod]
        public void TestNoWordName()
        {
            Assert.AreEqual("", FirstName(""));
            Assert.AreEqual("", LastName(""));
        }
    }
}