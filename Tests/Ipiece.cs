using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;

namespace Tests
{
    [TestClass]
    public class Ipiece
    {
        readonly PiceI pice = new PiceI();

        [TestMethod]
        public void I_DeepHole()
        {
            // ##### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(5, position.x);
        }

        [TestMethod]
        public void I_LeftHole()
        {
            //  #### # ##
            //  #### ####
            //  #########
            // 0I23456789
            var colums = new[] { 0, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.x);
        }

        [TestMethod]
        public void I_RightHole()
        {
            // ##### # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 2, 3, 2, 3, 1 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.x);
        }

        [TestMethod]
        public void I_HoleBetterThenFlat()
        {
            //     # # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 2, 2, 2, 3, 2, 3, 2, 3, 1 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.x);
        }

        [TestMethod]
        public void I_Flat()
        {
            //     # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 2, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.x);
        }

        [TestMethod]
        public void I_NotFlatNotHole()
        {
            //  #  # # #
            // ##########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 3, 2, 2, 3, 2, 3, 2, 3, 2 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.x);
        }

        [TestMethod]
        public void I_Steps()
        {
            //   #     #
            //  ###   ###
            // ##### ####
            // 0I23456789
            var colums = new[] { 1, 2, 3, 2, 1, 0, 1, 2, 3, 2 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.x);
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

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(9, position.x);
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

            var position = pice.GetFit(colums);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.x);
        }
    }
}
