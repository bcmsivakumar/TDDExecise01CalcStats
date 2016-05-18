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
            else {
                int? temp = null;
                for (int i = 0; i < sequenceNumbers.Length; i++)
                {
                    if (i == 0)
                    {
                        temp = sequenceNumbers[i];
                    }
                    else
                    {
                        if (sequenceNumbers[i] < temp)
                        {
                            temp = sequenceNumbers[i];
                        }
                    }
                }

                min = temp;
            }
            return min;
        }

        public int? Max()
        {
            int? maxValue = null;

            if (sequenceNumbers == null)
            {
                return maxValue;
            }

            for (int i = 0; i < sequenceNumbers.Length; i++)
            {
                if (i == 0)
                {
                    maxValue = sequenceNumbers[i];
                }
                else
                {
                    if (sequenceNumbers[i] > maxValue)
                    {
                        maxValue = sequenceNumbers[i];
                    }
                }
            }
            return maxValue;
        }
        
        public int Count()
        {
            return sequenceNumbers.Length;
        }

    }
}
