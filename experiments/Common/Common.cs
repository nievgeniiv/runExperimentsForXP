using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.Common
{
    class Common
    {

        public int[] arrayInt;
        public float[] arrayFloat;
        public float absoluteError;
        public float relativeError;
        
        public float getMediaValue(string type)
        {
            float sumData = 0;
            int count = 0;
            if (type == "float")
            {
                foreach (var value in arrayFloat)
                {
                    sumData += value;
                }

                count = arrayFloat.Length;
            }
            else
            {
                foreach (var value in arrayInt)
                {
                    sumData += value;
                }
                
                count = arrayInt.Length;
            }
            
            return sumData/count;
        }

        public float getError(float mediaValue, string type)
        {
            float sqrSum = 0;
            int count = 0;
            if (type == "float")
            {
                foreach (var value in arrayFloat)
                {
                    sqrSum = (value - mediaValue) * (value - mediaValue);
                }

                count = arrayFloat.Length;
            }
            else
            {
                foreach (var value in arrayInt)
                {
                    sqrSum = (value - mediaValue) * (value - mediaValue);
                }
                
                count = arrayInt.Length;
            }

            absoluteError = (float) (2.29 * Math.Sqrt(sqrSum) / (count * (count - 1)));
            relativeError = absoluteError / mediaValue;

            return absoluteError;
        }
        
    }
}
