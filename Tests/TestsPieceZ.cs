using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceZ
    {
        [TestMethod]
        public void Z_Hole1()
        {
            // # ### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 3, 3, 1, 3, 2, 3, 3 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(2, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(1, verticlePositions[0].X);
        }

        [TestMethod]
        public void Z_DeepHole()
        {
            // ##### # ##
            // ##### ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 0, 3, 2, 3, 3 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(1, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(7, verticlePositions[0].X);
        }

        [TestMethod]
        public void Z_FlatHoleBetterVerticleHole()
        {
            //      #  ##
            //  # #######
            //  #########
            // 0I23456789
            var colums = new[] { 0, 2, 1, 2, 2, 3, 2, 2, 3, 3 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(1, flatPositions.Count);
            Assert.AreEqual(3, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(5, flatPositions[0].X);
        }

        [TestMethod]
        public void Z_NotFlat()
        {
            // # # # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 2, 3, 2, 3, 2, 3, 2 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(4, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(1, verticlePositions[0].X);
        }

        [TestMethod]
        public void Z_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, verticlePositions.Count);
        }

        [TestMethod]
        public void Z_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(5, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(0, verticlePositions[0].X);
        }

        [TestMethod]
        public void Z_Steps2()
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

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(0, verticlePositions.Count);
        }

        [TestMethod]
        public void Z_Steps3()
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

            var flatPositions = PiceZ.PositionsFlat(colums);
            var verticlePositions = PiceZ.PositionsVerticle(colums);

            Assert.AreEqual(0, flatPositions.Count);
            Assert.AreEqual(9, verticlePositions.Count);

            foreach (var d in flatPositions)
                Assert.AreEqual(0, d.Rotation);
            foreach (var o in verticlePositions)
                Assert.AreEqual(1, o.Rotation);

            Assert.AreEqual(0, verticlePositions[0].X);
        }
    }
}
