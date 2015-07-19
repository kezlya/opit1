using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceL
    {
        [TestMethod]
        public void L_Hole1()
        {
            // # ### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 3, 3, 1, 3, 2, 3, 3 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(1, deepHolePositions.Count);
            Assert.AreEqual(2, flatHolePositions.Count);
            Assert.AreEqual(1, flatPositions.Count);
            Assert.AreEqual(3, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(4, deepHolePositions[0].X);
        }

        [TestMethod]
        public void L_DeepHole()
        {
            // # ### # ##
            // ##### ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 2, 3, 3, 3, 0, 3, 2, 3, 3 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(2, flatHolePositions.Count);
            Assert.AreEqual(1, flatPositions.Count);
            Assert.AreEqual(3, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(1, flatHolePositions[0].X);
        }

        [TestMethod]
        public void L_SmallHole()
        {
            //       # ##
            //  # #######
            //  #########
            // 0I23456789
            var colums = new[] { 0, 2, 1, 2, 2, 2, 3, 2, 3, 3 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(2, flatHolePositions.Count);
            Assert.AreEqual(1, flatPositions.Count);
            Assert.AreEqual(3, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(2, flatHolePositions[0].X);
        }

        [TestMethod]
        public void L_UpsideDown()
        {
            // #  # # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 3, 2, 3, 2, 3, 2, 3 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(1, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(1, notFlatPositions[0].X);
        }

        [TestMethod]
        public void L_NotFlat()
        {
            // # # # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 2, 3, 2, 3, 2, 3, 2 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, notFlatPositions.Count);
        }

        [TestMethod]
        public void L_Flat()
        {
            // #   # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 2, 3, 2, 3, 2, 3, 2 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(1, flatPositions.Count);
            Assert.AreEqual(2, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(1, flatPositions[0].X);
        }

        [TestMethod]
        public void L_UpsideDownHole()
        {
            // # # #     
            // ######  #
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 2, 3, 2, 1, 1, 2, 1 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(1, notFlatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(3, d.Rotation);
            foreach (var f in flatHolePositions)
                Assert.AreEqual(2, f.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);
            foreach (var n in notFlatPositions)
                Assert.AreEqual(1, n.Rotation);

            Assert.AreEqual(6, notFlatPositions[0].X);
        }

        [TestMethod]
        public void L_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, notFlatPositions.Count);
        }

        [TestMethod]
        public void L_Steps2()
        {
            // #
            // ##
            // ###
            // ####
            // #####
            // ######
            // #######  
            // ######## 
            // #########
            // 0I23456789
            var colums = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, notFlatPositions.Count);
        }

        [TestMethod]
        public void L_Steps3()
        {
            //          #
            //         ##
            //        ###
            //       ####
            //      #####
            //     ######
            //    #######  
            //   ######## 
            //  #########
            // 0I23456789
            var colums = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var deepHolePositions = PiceL.PositionsDeepHole(colums);
            var flatHolePositions = PiceL.PositionsFlatHole(colums);
            var flatPositions = PiceL.PositionsFlat(colums);
            var notFlatPositions = PiceL.PositionsNotFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, flatHolePositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, notFlatPositions.Count);
        }
    }
}
