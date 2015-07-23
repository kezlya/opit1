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

        #region GetColomnsAfter
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



        
        [TestMethod]
        public void TestGetColomnsAfterJrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 3, 2, 2, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 4, 4, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterJrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterLrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 2, 2, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 4, 2, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterLrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 4, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterOrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.O);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 1, 1, 1 }, result);
        }





        [TestMethod]
        public void TestGetColomnsAfterSrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.S);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterSrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.S);
            CollectionAssert.AreEqual(new[] { 1, 4, 3, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterTrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 2, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 4, 3, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterTrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 3, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterZrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.Z);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 2, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterZrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.Z);
            CollectionAssert.AreEqual(new[] { 1, 3, 4, 1, 1, 1 }, result);
        }
#endregion

        #region GetColomnsAfterWithHoles
        [TestMethod]
        public void TestGetColomnsAfterWithHolesJrotation0()
        {
            int[] columns = { 1, 7, 1, 8, 1, 9 };
            var result = columns.GetColomnsAfterWithHoles2(Start, 0, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 10, 9, 9, 1, 9 }, result);
        }

       /* [TestMethod]
        public void TestGetColomnsAfterWithHolesJrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 4, 4, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesJrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesJrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.J);
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterWithHolesLrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 2, 2, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesLrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 4, 2, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesLrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesLrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.L);
            CollectionAssert.AreEqual(new[] { 1, 4, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterWithHolesOrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.O);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 1, 1, 1 }, result);
        }





        [TestMethod]
        public void TestGetColomnsAfterWithHolesSrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.S);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesSrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.S);
            CollectionAssert.AreEqual(new[] { 1, 4, 3, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterWithHolesTrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 2, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesTrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 4, 3, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesTrotation2()
        {
            var result = _columns.GetColomnsAfter(Start, 2, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 3, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesTrotation3()
        {
            var result = _columns.GetColomnsAfter(Start, 3, PieceType.T);
            CollectionAssert.AreEqual(new[] { 1, 3, 4, 1, 1, 1 }, result);
        }




        [TestMethod]
        public void TestGetColomnsAfterWithHolesZrotation0()
        {
            var result = _columns.GetColomnsAfter(Start, 0, PieceType.Z);
            CollectionAssert.AreEqual(new[] { 1, 3, 3, 2, 1, 1 }, result);
        }

        [TestMethod]
        public void TestGetColomnsAfterWithHolesZrotation1()
        {
            var result = _columns.GetColomnsAfter(Start, 1, PieceType.Z);
            CollectionAssert.AreEqual(new[] { 1, 3, 4, 1, 1, 1 }, result);
        }*/
        #endregion
    }
}