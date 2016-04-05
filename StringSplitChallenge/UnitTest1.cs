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

            if (nameArray.Count() > 2)
            {
                return nameArray[0] + ' ' + nameArray[1];
            }
            return nameArray[0];
        }

        [TestMethod]
        public void TestLastName()
        {
            Assert.AreEqual("Pollock", LastName("Daniel Pollock"));
        }

        private string LastName(string v)
        {
            var nameArray = v.Split(' ');

            if (nameArray.Count() > 2)
            {
                return nameArray[2];
            }
            if (nameArray.Count() == 1)
            {
                return nameArray[0];
            }
            else
            {
                return nameArray[1];
            }
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