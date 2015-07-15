using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok.Pieces;

namespace Tests
{
    [TestClass]
    public class TestsPieceO
    {
        readonly PiceO _pice = new PiceO();

        [TestMethod]
        public void O_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void O_NotFlat()
        {
            //  #  # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 3, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(2, position.X);
        }

        [TestMethod]
        public void O_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
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

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(8, position.X);
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

            var position = _pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }
    }
}
