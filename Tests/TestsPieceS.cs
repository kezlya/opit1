using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceS
    {
        [TestMethod]
        public void S_Hole1()
        {
            // # ### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void S_DeepHole()
        {
            // ##### # ##
            // ##### ####
            // ##### ####
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 0, 3, 2, 3, 3 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(6, position.X);
        }

        [TestMethod]
        public void S_FlatHoleBetterVerticleHole()
        {
            //       # ##
            //  # #######
            //  #########
            // 0I23456789
            var colums = new[] { 0, 2, 1, 2, 2, 2, 3, 2, 3, 3 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(4, position.X);
        }

        [TestMethod]
        public void S_NotFlat()
        {
            // # # # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 2, 3, 2, 3, 2, 3, 2, 3, 2 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void S_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void S_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(4, position.X);
        }

        [TestMethod]
        public void S_Steps2()
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

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(8, position.X);
        }

        [TestMethod]
        public void S_Steps3()
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

            var position = PiceS.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }
    }
}
