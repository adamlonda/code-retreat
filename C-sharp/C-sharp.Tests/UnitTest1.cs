using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C_sharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestApplyRule()
        {
            World w = new World();

            w.Cells.Add(new Cell(1, 1));
            w.Cells.Add(new Cell(2, 1));
            w.Cells.Add(new Cell(1, 2));
            w.Cells.Add(new Cell(2, 2));

            Assert.AreEqual(w.GetNeighbours(new Cell(1, 1)).Count, 3);
            Assert.AreEqual(w.GetNeighbours(new Cell(0, 0)).Count, 1);
            Assert.AreEqual(w.GetNeighbours(new Cell(1, 3)).Count, 2);

            //Assert.AreEqual(w.ApplyRule(true, 2), true, "alive cell with 2 neighbours should stay alive");
            //Assert.AreEqual(w.ApplyRule(true, 3), true, "alive cell with 3 neighbours should stay alive");
            //Assert.AreEqual(w.ApplyRule(false, 3), true, "dead cell with 3 neighbours should be born");
            //Assert.AreEqual(w.ApplyRule(false, 2), false, "dead cell with 2 neighbours should stay dead");

        }

        [TestMethod]
        public void TestGetNeighbours()
        {
            World w = new World();
            w.Cells.Add(0, 0);
            w.Cells.Add(0, 1);
            w.Cells.Add(1, 1);

            Assert.AreEqual(w.GetAliveNeighbours(new Tuple<int, int>(0, 0)).Length, 2, "This cell has 2 alive neighbours");
        }
    }
}
