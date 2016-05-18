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
    public class SequenceLengthCalcStatsTest
    {
        [TestMethod]
        public void Count_EmptySequence()
        {
            CalcStats calcStat = new CalcStats(new int[] { });
            int length = calcStat.Count();

            Assert.AreEqual(0, length);
        }        
    }
}
