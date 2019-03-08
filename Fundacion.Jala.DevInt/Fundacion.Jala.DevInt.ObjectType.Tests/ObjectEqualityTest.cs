using Fundacion.Jala.DevInt.Shared.Models.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
