using Fundacion.Jala.DevInt.Shared.Models.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fundacion.Jala.DevInt.ObjectType.Tests
{
    [TestClass]
    public class ObjectEqualityTest
    {
        [TestMethod]
        public void Equals_Operator_Should_Compare_Two_Identical_Points()
        {
            var origin = new Point2D() { X = 0, Y = 5 };
            var origin2 = new Point2D() { X = 0, Y = 5 };
            Assert.AreEqual(origin, origin2);
        }

        [TestMethod]
        public void Equals_Operator_Should_Compare_Two_Different_Points()
        {
            var origin = new Point2D() { X = 1, Y = 5 };
            var origin2 = new Point2D() { X = 0, Y = 5 };
            Assert.AreNotEqual(origin, origin2);
        }

        [TestMethod]
        public void Test_Clone()
        {
            var origin = new Point2D() { X = 1, Y = 5 };
            var origin2 = origin.Clone();
            origin2.X = 2;
            Assert.AreNotEqual(origin, origin2);
        }

        [TestMethod]
        public void Test_String_Equals()
        {
            var text = "Value1";
            var text2 = "valUe1";
            if (text == text2)
            {

            }
            var areEqual = text.Equals(text2, StringComparison.CurrentCultureIgnoreCase);
            Assert.IsTrue(areEqual);
        }
    }
}
