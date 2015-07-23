using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;

namespace Tests
{
    [TestClass]
    public class TestsHelper
    {
        [TestMethod]
        public void Md_Z_NotFlat()
        {
            //      #  
            //    # #  
            //    # #  
            //  # # #  
            //  # # #  
            //  # # # #
            //  # # # #
            //  # # # #
            // 0I23456789
            var columns = new[] { 0, 5, 0, 7, 0, 8, 0, 3, 0, 0 };
            var type = PieceType.Z;

            var position = Helper.MinimumDamagePosition(type, columns);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(8, position.X);
        }

        [TestMethod]
        public void Md_Z_Flat()
        {
            // ##########
            // ##########
            // ##########
            // 0I23456789
            var columns = new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            var type = PieceType.Z;

            var position = Helper.MinimumDamagePosition(type, columns);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(0, position.X);
        }

        [TestMethod]
        public void Md_Z_Steps()
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
            var type = PieceType.Z;

            var position = Helper.MinimumDamagePosition(type, colums);

            Assert.AreEqual(0, position.Rotation);
            Assert.AreEqual(7, position.X);
        }

        [TestMethod]
        public void Md_S_NotFlat()
        {
            //    ##  
            //    ## ##
            //  # ##### #
            // ## ##### #
            // ######## #
            // 0I23456789
            var columns = new[] { 2, 3, 1, 5, 5, 3, 4, 4, 0, 3 };
            var type = PieceType.S;

            var position = Helper.MinimumDamagePosition(type, columns);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(1, position.X);
        }

        [TestMethod]
        public void Md_J_NotFlat()
        {
            //     
            //     # 
            //    ## 
            //    ###  
            //    ####
            //  # ##### 
            //  ########
            //  ######## 
            // 0I23456789
            var columns = new[] { 0, 3, 2, 6, 7, 5, 4, 3, 2, 0 };
            var type = PieceType.J;

            var position = Helper.MinimumDamagePosition(type, columns);

            Assert.AreEqual(1, position.Rotation);
            Assert.AreEqual(0, position.X);
        }
        //TODO: more tests
    }
}
