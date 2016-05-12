using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExecise01CalcStats
{
    public class CalcStats
    {
        private int[] sequenceNumbers;

        public CalcStats()
        {
        }

        public CalcStats(int[] sequenceNumbers)
        {
            this.sequenceNumbers = sequenceNumbers;
        }

        public int? Min()
        {
            int? min = null;
            if (sequenceNumbers == null)
            {
                min = null;
            }
            else if (sequenceNumbers.Length == 1)
            {
                min = sequenceNumbers[0];
            }
            else if(sequenceNumbers.Length==2)
            {
                if(sequenceNumbers[0]<sequenceNumbers[1])
                {
                    min = sequenceNumbers[0];
                }
                else
                {
                    min = sequenceNumbers[1];
                }
            }
            return min;
        }
    }
}
