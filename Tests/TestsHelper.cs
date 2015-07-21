using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;

namespace Tests
{
    [TestClass]
    public class TestsHelper
    {
        [TestMethod]
        public void TestMinimumDamagePosition()
        {
            var type = PieceType.Z;
            var columns = new [] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var position = Helper.MinimumDamagePosition(type, columns);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(12, position.X);
        }
    }
}
