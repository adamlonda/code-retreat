using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C_sharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private HashSet<List<int>> emptyHashSet = new HashSet<List<int>>();

        private bool AliveCellDies(bool isAlive, int neighborsCount)
        {
            // Rule1
            return isAlive && neighborsCount < 2;
        }

        [TestMethod]
        public void TestRule1()
        {
            Assert.IsTrue(AliveCellDies(isAlive: true, neighborsCount: 0));
            Assert.IsTrue(AliveCellDies(isAlive: true, neighborsCount: 1));
            Assert.IsFalse(AliveCellDies(isAlive: true, neighborsCount: 2));
            Assert.IsFalse(AliveCellDies(isAlive: false, neighborsCount: 2));
            Assert.IsFalse(AliveCellDies(isAlive: false, neighborsCount: 1));
        }

        [TestMethod]
        public void TestAppliedRule1()
        {
            HashSet<List<int>> aliveCells = new HashSet<List<int>>
            {
                new List<int> { 0, 0 },
                new List<int> { 1, 1 },
            };

            Assert.AreEqual(ApplyFirstRule(aliveCells), emptyHashSet);       
        }

        private HashSet<List<int>> ApplyFirstRule(HashSet<List<int>> aliveCells)
        {
            return new HashSet<List<int>>();
        }
    }
}
