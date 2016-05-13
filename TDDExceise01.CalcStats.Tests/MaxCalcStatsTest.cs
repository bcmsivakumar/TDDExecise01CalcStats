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
    public class MaxCalcStatsTest
    {

        [TestMethod]
        public void Max_With_ClassInstance_with_ParameterisedConstructor_NullAsSequenceNumber()
        {
            CalcStats calcStat = new CalcStats(null);
            int? maxValue = calcStat.Max();

            Assert.AreEqual(null, maxValue);
        }

        [TestMethod]
        public void Max_With_EmptySequenceNumber()
        {
            CalcStats calcStat = new CalcStats(new int[] { });
            int? maxValue = calcStat.Max();

            Assert.AreEqual(null, maxValue);
        }

        [TestMethod]
        public void Max_With_SingleSequenceNumber()
        {
            CalcStats calcStat = new CalcStats(new int[] { 100 });
            int? maxValue = calcStat.Max();

            Assert.AreEqual(100, maxValue);
        }

    }
}
