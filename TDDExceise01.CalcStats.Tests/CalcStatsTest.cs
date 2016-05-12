using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExecise01CalcStats;

namespace TDDExceise01CalcStats.Tests
{
    [TestClass]
    public class CalcStatsTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void MinValue_Without_ClassInstance()
        {
            CalcStats calcStat = null;
            int? minValue = calcStat.Min();
            Assert.AreEqual(null, minValue);
        }

        [TestMethod]
        public void MinValue_With_ClassInstance_with_ParameterlessConstructor()
        {
            CalcStats calcStat = new CalcStats();
            int? minValue = calcStat.Min();

            Assert.AreEqual(null, minValue);
        }

        [TestMethod]
        public void MinValue_With_ClassInstance_with_ParameterisedConstructor_NullAsSequenceNumber()
        {
            CalcStats calcStat = new CalcStats(null);
            int? minValue = calcStat.Min();

            Assert.AreEqual(null, minValue);
        }        

        [TestMethod]
        public void MinValue_With_EmptySequenceNumber()
        {
            CalcStats calcStat=new CalcStats(new int[] { });
            int? minValue = calcStat.Min();

            Assert.IsNull(minValue);
        }

        [TestMethod]
        public void MinValue_With_SingleSequenceNumber()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2 });
            int? minValue = calcStat.Min();

            Assert.AreEqual(2, minValue);
        }

        [TestMethod]
        public void MinValue_with_TwoSequenceNumbers()
        {
            CalcStats calcStat = new CalcStats(new int[] { 2, 1 });
            int? minValue = calcStat.Min();

            Assert.AreEqual(1, minValue);
        }

    }
}
