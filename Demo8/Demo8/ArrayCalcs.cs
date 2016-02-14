using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    public static class ArrayCalcs
    {
        public static double Sum(double[] table)
        {
            double sum = 0;
            if (table.Length != 0)
            {
                foreach (double value in table)
                {
                    sum += value;
                }
            }

            return sum;
        }

        public static double Average(double[] table)
        {
            double average = 0;
            int size = table.Length;

            if(size != 0)
            {
                average = Math.Round(Sum(table) / size, 2);
            }

            return average;
        }

        public static double Min(double[] table)
        {
            double min = 0;

            if (table.Length != 0)
            {
                min = table.Min();
            }
            return min;
        }

        public static double Max(double[] table)
        {
            double max = 0;
            if(table.Length != 0)
            {
                max = table.Max();
            }
            return max;

        }
    }
}
