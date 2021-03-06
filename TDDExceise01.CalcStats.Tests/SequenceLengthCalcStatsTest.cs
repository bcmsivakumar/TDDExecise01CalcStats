﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDExecise01CalcStats;

namespace TDDExceise01CalcStats.Tests
{
    [TestClass]
    public class SequenceLengthCalcStatsTest
    {
        [TestMethod]
        public void Count_EmptySequence()
        {
            CalcStats calcStat = new CalcStats(new int[] { });
            int length = calcStat.Count();

            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void Count_OneSequence()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2 });
            int length = calcStat.Count();

            Assert.AreEqual(1, length);
        }

        [TestMethod]
        public void Count_MoreThanOneSequence()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2, -3, 1 });
            int length = calcStat.Count();

            Assert.AreEqual(3, length);
        }
    }
}
