using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyClassLibraryTest
{
    [TestClass]
    public class MyLibraryTest
    {
        [TestMethod]
        public void TestMathPass()
        {
            var myLibrary = new MyLibrary();

            var res = myLibrary.Plus(1, 1);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMathFail()
        {
            var myLibrary = new MyLibrary();

            var res = myLibrary.Plus(1, 1);
            Assert.AreNotEqual(2, res);
        }
    }
}
