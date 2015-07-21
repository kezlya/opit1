using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirozgok;
using Pirozgok.Commands;

namespace Tests
{
    [TestClass]
    public class TestsPerformance
    {
        string rawInput = "0,0,0,1,1,1,0,0,0,0;0,0,0,0,0,0,0,0,0,0;0,0,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;0,2,0,0,0,0,0,0,0,0;0,2,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;2,2,0,0,0,0,0,0,0,0;2,2,0,0,0,2,0,0,0,0;2,2,0,2,0,2,2,0,0,0;2,2,2,2,0,2,2,2,0,0;0,2,2,2,2,2,2,2,2,0;2,2,2,2,2,2,2,2,2,0;2,2,2,2,2,2,2,2,2,0;2,2,2,2,2,2,2,2,2,0;2,2,2,2,2,2,2,2,2,0;2,2,0,0,2,2,2,2,2,0";
        private int[] expectedColums = new[] {17, 17, 7, 8, 6, 9, 8, 7, 6, 0};

        //[TestMethod]
        //public void FieldParcer()
        //{
        //    var field = new Pirozgok.Field(10,20);
        //    field.Parse(rawInput);
        //    var flat = field.Grid.ToEnumerable<FieldCell>();
        //    var accupiedCells = flat.Where(x => x.Type == FieldCellType.Block || x.Type == FieldCellType.Solid).ToList();
        //    int[] columns = new int[field.Width];

        //    foreach (var cell in accupiedCells)
        //    {
        //        var yy = field.Height - cell.Y;
        //        if (yy > columns[cell.X]) columns[cell.X] = yy;
        //    }

        //    CollectionAssert.AreEqual(expectedColums, columns);

        //}

        //[TestMethod]
        //public void FieldParcer2()
        //{
        //    var field2 = new Pirozgok.Field2(10, 20);
        //    field2.Parse(rawInput);

        //    CollectionAssert.AreEqual(expectedColums, field2.Colums);
        //}
    }
}
