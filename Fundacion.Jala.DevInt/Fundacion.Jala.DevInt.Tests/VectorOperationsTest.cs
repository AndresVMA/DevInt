using Fundacion.Jala.DevInt.Shared.Models.Classes;
using Fundacion.Jala.DevInt.Shared.Models.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundacion.Jala.DevInt.Tests
{
    [TestClass]
    public class VectorOperationsTest
    {
        [TestMethod]
        public void Should_Add_Successfully_Given_Two_Valid_Vectors()
        {
            var vector1 = new Vector2D(2.1f, 7.3f);
            var vector2 = new Vector2D(3.9f, 2.7f);
            var sumResult = vector1 + vector2;
            Assert.AreEqual(6, sumResult.X);
            Assert.AreEqual(10, sumResult.Y);
        }

        [TestMethod]
        public void Should_Calculate_The_Dot_Product_Successfully_Given_Two_Valid_Vectors()
        {
            var vector1 = new Vector2D(2f, 5f);
            var vector2 = new Vector2D(3f, 6f);

            //var dotProductResult = Vector2DExtensions.Dot(vector1, vector2);
            var dotProductResult = vector1.Dot(vector2);
            Assert.AreEqual(36, dotProductResult);
        }
    }
}
