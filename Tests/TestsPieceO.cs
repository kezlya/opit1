using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceO
    {
        [TestMethod]
        public void O_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, oneLevelStepPositions.Count);
            Assert.AreEqual(9, flatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in oneLevelStepPositions)
                Assert.AreEqual(0, o.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);

            Assert.AreEqual(0, flatPositions[0].X);
        }

        [TestMethod]
        public void O_DeepHoleHasPriority()
        {
            // #  ###  ##
            // ######  ##
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 3, 3, 3, 1, 1, 3, 3 };

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(1, deepHolePositions.Count);
            Assert.AreEqual(2, oneLevelStepPositions.Count);
            Assert.AreEqual(5, flatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in oneLevelStepPositions)
                Assert.AreEqual(0, o.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);

            Assert.AreEqual(6, deepHolePositions[0].X);
        }

        [TestMethod]
        public void O_NotFlat()
        {
            //  #  # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 3, 2, 2, 3, 2, 3, 2, 3, 2 };

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(1, oneLevelStepPositions.Count);
            Assert.AreEqual(1, flatPositions.Count);

            foreach (var d in deepHolePositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in oneLevelStepPositions)
                Assert.AreEqual(0, o.Rotation);
            foreach (var f in flatPositions)
                Assert.AreEqual(0, f.Rotation);

            Assert.AreEqual(2, oneLevelStepPositions[0].X);
        }

        [TestMethod]
        public void O_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, oneLevelStepPositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
        }

        [TestMethod]
        public void O_Steps2()
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

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, oneLevelStepPositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
        }

        [TestMethod]
        public void O_Steps3()
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

            var deepHolePositions = PiceO.PositionsDeepHole(colums);
            var oneLevelStepPositions = PiceO.PositionsOneLevelStep(colums);
            var flatPositions = PiceO.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, oneLevelStepPositions.Count);
            Assert.AreEqual(0, flatPositions.Count);
        }
    }
}
