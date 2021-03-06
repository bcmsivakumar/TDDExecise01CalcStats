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
    public class AverageCalcStatsTest
    {
        [TestMethod]
        public void Average_NUll_SequenceNumber()
        {
            CalcStats calcStat = new CalcStats(null);
            double? averageValue = calcStat.Average();

            Assert.AreEqual(null, averageValue);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Average_With_EmptySequenceNumber()
        {
            CalcStats calcStat = new CalcStats(new int[] { });
            double? averageValue = calcStat.Average();

            Assert.AreEqual(0, averageValue);
        }

        [TestMethod]
        public void Average_With_OneSequnceNumber()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2 });
            double? averageValue = calcStat.Average();

            Assert.AreEqual(2, averageValue);
        }

        [TestMethod]
        public void Average_With_TwoSequnceNumbers()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2, 3 });
            double? averageValue = calcStat.Average();

            Assert.AreEqual(2.5, averageValue);
        }

        [TestMethod]
        public void Average_With_MoreThanTwoSequnceNumbers()
        {
            CalcStats calcStat = new CalcStats(new int[] { 6, 9, 15, -2, 92, 11 });
            double? averageValue = calcStat.Average();

            Assert.AreEqual(21.833333, averageValue);
        }

        [TestMethod]
        public void Average_With_MoreThanTwoSequnceNumbersSameNumbers()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2, 2, 2, 2 });
            double? averageValue = calcStat.Average();

            Assert.AreEqual(2, averageValue);
        }
    }
}
