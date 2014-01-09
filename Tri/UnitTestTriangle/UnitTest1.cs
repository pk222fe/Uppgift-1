using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace TriUnitTest
{
    // Isosceles = Likbent
    // Equilateral = Liksidig
    // Scalene = Oliksidig

    [TestClass]
    public class TestSuitOne
    {

        // Testar indata mot utdata.
        [TestMethod]
        public void TestScaleneIsIsoscelesFail()
        {
            Triangle tri = new Triangle(3, 0.5, 6);
            Assert.IsFalse(tri.isIsosceles());
        }

        [TestMethod]
        public void TestEquilateralIsIsoscelesFail()
        {
            Triangle tri = new Triangle(5.0, 5, 5.0);
            Assert.IsFalse(tri.isIsosceles());
        }

        [TestMethod]
        public void TestIsoscelesIsIsoscelesPass()
        {
            Triangle tri = new Triangle(10.0, 5.0, 10.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void TestScaleneIsEquilateralFail()
        {
            Triangle tri = new Triangle(5, 6.5, 11);
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        public void TestEquilateralIsEquilateralPass()
        {
            Triangle tri = new Triangle(10.0, 10.0, 10.0);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void TestIsoscelesIsEquilateralFail()
        {
            Triangle tri = new Triangle(5, 10, 5.0);
            Assert.IsFalse(tri.isEquilateral());
        }

        [TestMethod]
        public void TestScaleneIsScalenePass()
        {
            Triangle tri = new Triangle(5, 10, 15);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void TestEquilateralIsScaleneFail()
        {
            Triangle tri = new Triangle(10, 10.0, 10);
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        public void TestIsoscelesIsScaleneFail()
        {
            Triangle tri = new Triangle(15, 15, 10);
            Assert.IsFalse(tri.isScalene());
        }


        // Konstruktortester.
        [TestMethod]
        public void ThreePointPass()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);

            new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NoPointElementException()
        {
            new Triangle(new Point[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OnePointElementException()
        {
            Point a = new Point(3, 3);

            new Triangle(new Point[] { a });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoPointElementException()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);

            new Triangle(new Point[] { a, b });
        }

        [TestMethod]
        public void ThreePointElementPass()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);

            new Triangle(new Point[] { a, b, c });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FourPointElementException()
        {
            Point a = new Point(3, 3);
            Point b = new Point(4, 4);
            Point c = new Point(5, 5);
            Point d = new Point(6, 6);

            new Triangle(new Point[] { a, b, c, d });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArrOneElementException()
        {
            new Triangle(new double[] { 3 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArrTwoElementException()
        {
            new Triangle(new double[] { 3, 4 });
        }

        [TestMethod]
        public void ArrThreeElementPass()
        {
            new Triangle(new double[] { 3, 4, 5 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArrFourElementException()
        {
            new Triangle(new double[] { 3, 4, 5, 6 });
        }


        // Testar med negativa värden.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeValueException()
        {
            Triangle tri = new Triangle(new double[] { -3, -4.0, -5 });
        }


        //Testar med maxvärden.
        [TestMethod]
        public void TestMaxValuePass()
        {
            Triangle tri = new Triangle(new double[] { 9223372036854775807, 9223372036854775807, 9223372036854775807 });
        }
    }
}