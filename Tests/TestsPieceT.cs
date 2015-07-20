using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceT
    {
        [TestMethod]
        public void T_Hole1()
        {
            // #  ## # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 3, 3, 1, 3, 2, 3, 3 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(1, pointDownPositions.Count);
            Assert.AreEqual(2, pointLeftPositions.Count);
            Assert.AreEqual(2, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(6, pointDownPositions[0].X);
        }

        [TestMethod]
        public void T_DeepHole()
        {
            // #  ## # ##
            // # ### ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 1, 2, 3, 3, 0, 3, 2, 3, 3 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(1, pointDownPositions.Count);
            Assert.AreEqual(1, pointLeftPositions.Count);
            Assert.AreEqual(3, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(6, pointDownPositions[0].X);
        }

        [TestMethod]
        public void T_LeftDeepHole()
        {
            // # ##  # ##
            // # ##  ####
            // #### #####
            // 0I23456789
            var colums = new[] { 3, 1, 3, 3, 0, 1, 3, 2, 3, 3 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(1, pointDownPositions.Count);
            Assert.AreEqual(1, pointLeftPositions.Count);
            Assert.AreEqual(2, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(4, pointRightPositions[0].X);
        }

        [TestMethod]
        public void T_RightDeepHole()
        {
            // # ##  # ##
            // # ##  ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 1, 3, 3, 1, 0, 3, 2, 3, 3 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(1, pointDownPositions.Count);
            Assert.AreEqual(2, pointLeftPositions.Count);
            Assert.AreEqual(1, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(4, pointLeftPositions[0].X);
        }


        [TestMethod]
        public void T_FlatBetterThenUpsideDown()
        {
            // #   # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 2, 3, 2, 3, 2, 3, 2 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(1, pointUpPositions.Count);
            Assert.AreEqual(2, pointDownPositions.Count);
            Assert.AreEqual(4, pointLeftPositions.Count);
            Assert.AreEqual(3, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(1, pointUpPositions[0].X);
        }


        [TestMethod]
        public void T_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(1, pointDownPositions.Count);
            Assert.AreEqual(4, pointLeftPositions.Count);
            Assert.AreEqual(5, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(4, pointDownPositions[0].X);
        }

        [TestMethod]
        public void T_Steps2()
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

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(0, pointDownPositions.Count);
            Assert.AreEqual(9, pointLeftPositions.Count);
            Assert.AreEqual(0, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(8, pointLeftPositions[8].X);
        }

        [TestMethod]
        public void T_Steps3()
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

            var pointUpPositions = PiceT.PositionsPointUp(colums);
            var pointDownPositions = PiceT.PositionsPointDown(colums);
            var pointLeftPositions = PiceT.PositionsPointLeft(colums);
            var pointRightPositions = PiceT.PositionsPointRight(colums);

            Assert.AreEqual(0, pointUpPositions.Count);
            Assert.AreEqual(0, pointDownPositions.Count);
            Assert.AreEqual(0, pointLeftPositions.Count);
            Assert.AreEqual(9, pointRightPositions.Count);

            foreach (var u in pointUpPositions)
                Assert.AreEqual(0, u.Rotation);
            foreach (var d in pointDownPositions)
                Assert.AreEqual(2, d.Rotation);
            foreach (var l in pointLeftPositions)
                Assert.AreEqual(3, l.Rotation);
            foreach (var r in pointRightPositions)
                Assert.AreEqual(1, r.Rotation);

            Assert.AreEqual(0, pointRightPositions[0].X);
        }
    }
}
