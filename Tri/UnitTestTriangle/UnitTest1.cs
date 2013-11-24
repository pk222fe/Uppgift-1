using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestIsScalene()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void TestIsEquilateral()
        {
            Triangle tri2 = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(tri2.isEquilateral());
        }

        [TestMethod]
        public void TestIsIsosceles()
        {
            Triangle tri3 = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri3.isIsosceles());
        }
    }
}
