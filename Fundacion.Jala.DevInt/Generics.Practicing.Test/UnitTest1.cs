using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics.Practicing.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var partOperations = new DataOperations<PartBase>();
            var wheel = partOperations.Create<Wheel>();
            partOperations.Save(wheel);
            var window = partOperations.Create<Window>();
            partOperations.Save(window);
            var door = partOperations.Create<Door>();
            partOperations.Save(door);
            Assert.AreEqual(3, partOperations.Data.Count);
        }
    }
}
