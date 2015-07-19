using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceExtentions
    {
        readonly int[] _columns = { 1, 1, 1, 1, 1, 1 };
        private const int Start = 1;

        [TestMethod]
        public void TestGetColomnsAfterIrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.I);
            CollectionAssert.AreEqual(new[] { 1, 2, 2, 2, 2, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterIrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.I);
            CollectionAssert.AreEqual(new[] { 1, 5, 1, 1, 1, 1 }, result);
        }



        /*
        [TestMethod]
        public void TestGetColomnsAfterJrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.J);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.J);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.J);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.J);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfteLJrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.L);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.L);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.L);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.L);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterOrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.O);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }





        [TestMethod]
        public void TestGetColomnsAfterSrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.S);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterSrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.S);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterTrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.T);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.T);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.T);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.T);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterZrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.Z);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterZrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.Z);
            Assert.AreEqual(new[] { 1, 0, 0, 0, 0, 1 }, result);
        }
        */
    }
}
