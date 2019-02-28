using Fundacion.Jala.DevInt.NetFrameworkApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fundacion.Jala.DevInt.Tests
{
    [TestClass]
    public class InputAdapterTests
    {
        [TestMethod]
        public void Should_Create_Vectors_For_Valid_Input_Arguments()
        {
            var xPositionA = 2f;
            var yPositionA = -3f;
            var xPositionB = 4f;
            var yPositionB = 6f;
            var arguments = new string[] { $"{xPositionA},{yPositionA}", $"{xPositionB},{yPositionB}" };
            var adapter = new InputAdapter(arguments);
            var vectorA = adapter.VectorA;
            var vectorB = adapter.VectorB;
            Assert.AreEqual(xPositionA, vectorA.X);
            Assert.AreEqual(yPositionA, vectorA.Y);
            Assert.AreEqual(xPositionB, vectorB.X);
            Assert.AreEqual(yPositionB, vectorB.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_One_Argument_Is_Missing()
        {
            var arguments = new string[] { "2,3" };
            var adapter = new InputAdapter(arguments);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Arguments_Are_Not_Numbers()
        {
            var arguments = new string[] { "2,3", "A,B" };
            var adapter = new InputAdapter(arguments);
        }
    }
}
