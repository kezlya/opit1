using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;

namespace Tests
{
    [TestClass]
    public class Ipiece
    {
        readonly PiceI pice = new PiceI();

        [TestMethod]
        public void I_DeepHoll()
        {
            // ##### # ##
            // ##### ####
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(position.Rotation, 1);
            Assert.AreEqual(position.x, 5);
        }

        [TestMethod]
        public void I_LeftHoll()
        {
            //  #### # ##
            //  #### ####
            //  #########
            // 0I23456789
            var colums = new[] { 0, 3, 3, 3, 3, 1, 3, 2, 3, 3 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(position.Rotation, 1);
            Assert.AreEqual(position.x, 0);
        }

        [TestMethod]
        public void I_RightHoll()
        {
            // ##### # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 3, 3, 3, 3, 3, 2, 3, 2, 3, 1 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(position.Rotation, 1);
            Assert.AreEqual(position.x, 9);
        }

        [TestMethod]
        public void I_HollBetterThenFlat()
        {
            //     # # #
            // #########
            // ##########
            // 0I23456789
            var colums = new[] { 2, 2, 2, 2, 3, 2, 3, 2, 3, 1 };

            var position = pice.GetFit(colums);

            Assert.AreEqual(position.Rotation, 1);
            Assert.AreEqual(position.x, 9);
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

            Assert.AreEqual(position.Rotation, 0);
            Assert.AreEqual(position.x, 0);
        }
    }
}
