using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
