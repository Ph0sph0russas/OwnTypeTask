using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VectorTest()
        {
            var testVector = new Vector(10, 20, 30);
            Assert.AreEqual(new Vector(10,20,30), testVector);
        }
        [TestMethod()]
        public void operatorPlusTest1()
        {
            var vectorOne = new Vector(1, 10, 100);
            var vectorTwo = new Vector(2000, 20000, 2000000);
            var vectorResult = vectorOne + vectorTwo;
            Assert.AreEqual(new Vector(2001,20010,2000100), vectorResult);
        }

        [TestMethod()]
        public void operatorPlusTest2()
        {
            var vectorOne = new Vector(-1, -10, -123);
            var vectorTwo = new Vector(-2000, -20000, 20);
            var vectorResult = vectorOne + vectorTwo;
            Assert.AreEqual(new Vector(-2001,-20010,-103), vectorResult);
        }

        [TestMethod()]
        public void operatorMinusTest1()
        {
            var vectorOne = new Vector(1, 10, 100);
            var vectorTwo = new Vector(2000, 20000, 2000000);
            var vectorResult = vectorOne - vectorTwo;
            Assert.AreEqual(new Vector(-1999,-19990,-1999900), vectorResult);
        }

        [TestMethod()]
        public void operatorMinusTest2()
        {
            var vectorOne = new Vector(1234, 1555, 223);
            var vectorTwo = new Vector(1000, 555, 200);
            var vectorResult = vectorOne - vectorTwo;
            Assert.AreEqual(new Vector(234,1000,23), vectorResult);
        }

        [TestMethod()]
        public void operatorScalarTest1()
        {
            var vectorOne = new Vector(1, -10, 100);
            var vectorTwo = new Vector(2000, 20000, 2000000);
            var result = vectorOne * vectorTwo;
            Assert.AreEqual(199802000, result);
        }

        [TestMethod()]
        public void operatorScalarTest2()
        {
            var vectorOne = new Vector(-10, 5, 0);
            var vectorTwo = new Vector(2000, 200, 2000000);
            var result = vectorOne * vectorTwo;
            Assert.AreEqual(-19000, result);
        }
        [TestMethod()]
        public void operatorCrossTest1()
        {
            var vectorOne = new Vector(-10, 50, 12);
            var vectorTwo = new Vector(20, 34, 55);
            var vectorResult = vectorOne & vectorTwo;
            Assert.AreEqual(new Vector(2342,790,-1340), vectorResult);
        }

        [TestMethod()]
        public void operatorCrossTest2()
        {
            var vectorOne = new Vector(-12, -24, -87);
            var vectorTwo = new Vector(100, 18, 37);
            var vectorResult = vectorOne & vectorTwo;
            Assert.AreEqual(new Vector(678,-8256,2184), vectorResult);
        }

        [TestMethod()]
        public void CalculateVectorLengthTest1()
        {
            var vectorOne = new Vector(1, 2, 2);
            Assert.AreEqual(3, vectorOne.CalculateVectorLength());
        }

        [TestMethod()]
        public void CalculateVectorLengthTest2()
        {
            var vectorOne = new Vector(0, 0, -11);
            Assert.AreEqual(11, vectorOne.CalculateVectorLength());
        }
    }
}