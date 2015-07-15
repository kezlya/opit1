using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceT
    {
        readonly PiceT _pice = new PiceT();

        [TestMethod]
        public void T_Hole1()
        {
            // #  ## # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 3, 3, 1, 3, 2, 3, 3 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(2, position.Rotation);
            Assert.AreEqual(6, position.X);
        }

        [TestMethod]
        public void T_DeepHole()
        {
            // #  ## # ##
            // # ### ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 1, 2, 3, 3, 0, 3, 2, 3, 3 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(2, position.Rotation);
            Assert.AreEqual(6, position.X);
        }

        [TestMethod]
        public void T_LeftDeepHole()
        {
            // # ##  # ##
            // # ##  ####
            // #### #####
            // 0I23456789
            var colums = new[] { 3, 1, 3, 3, 0, 1, 3, 2, 3, 3 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(4, position.X);
        }

        [TestMethod]
        public void T_RightDeepHole()
        {
            // # ##  # ##
            // # ##  ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 1, 3, 3, 1, 0, 3, 2, 3, 3 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(3, position.Rotation);
            Assert.AreEqual(4, position.X);
        }


        [TestMethod]
        public void T_FlatBetterThenUpsideDown()
        {
            // #   # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(1, position.X);
        }


        [TestMethod]
        public void T_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(2, position.Rotation);
            Assert.AreEqual(4, position.X);
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

            var position = _pice.GetFit(colums);

            Assert.AreEqual(3, position.Rotation);
            Assert.AreEqual(8, position.X);
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

            var position = _pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }
    }
}
