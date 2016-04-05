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
            var name = v.Split(' ').ToList();
            if(name.Count > 1)
            name.RemoveAt(name.Count - 1);

            return string.Join(" ", name.ToArray());
        }

        [TestMethod]
        public void TestLastName()
        {
            Assert.AreEqual("Pollock", LastName("Daniel Pollock"));
        }

        private string LastName(string v)
        {
            var name = v.Split(' ').ToList();
            return name.Last();
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