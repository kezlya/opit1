﻿using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceI
    {
        [TestMethod]
        public void I_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            var deepHolePositions = PiceI.PositionsDeepHole(colums);
            var oneLevelPositions = PiceI.PositionsOneLevelStep(colums);
            var flatPositions = PiceI.PositionsFlat(colums);

            Assert.AreEqual(0, deepHolePositions.Count);
            Assert.AreEqual(0, oneLevelPositions.Count);
            Assert.AreEqual(7, flatPositions.Count);
            //Shift Right
            Assert.AreEqual(1, flatPositions[0].X);
            Assert.AreEqual(0, flatPositions[1].X);
            foreach (var flatPosition in flatPositions)
                Assert.AreEqual(0, flatPosition.Rotation);
        }
        /*
        [TestMethod]
        public void I_DeepHole()
        {
            // ##### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(5, position.X);
        }

        [TestMethod]
        public void I_LeftHole()
        {
            //  #### # ##
            //  #### ####
            //  #########
            // 0I23456789
            var colums = new[] { 0, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void I_RightHole()
        {
            // ##### # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 2, 3, 2, 3, 1 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.X);
        }

        [TestMethod]
        public void I_HoleBetterThenFlat()
        {
            //     # # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 2, 2, 2, 3, 2, 3, 2, 3, 1 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.X);
        }

        [TestMethod]
        public void I_FlatWithBumps()
        {
            //     # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 2, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void I_NotFlatNotHole()
        {
            //  #  # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 3, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void I_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void I_Steps2()
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

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.X);
        }

        [TestMethod]
        public void I_Steps3()
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

            var position = PiceI.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }*/
    }
}
