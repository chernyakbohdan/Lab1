using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Array1D
    {
        public bool error = false;
        private double[] a;
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Array1D()
        {
            Length = 0;
            a = new double[Length];
        }

        public Array1D(int size)
        {
            Length = size;
            a = new double[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                // Випадкова температура від -15 до 5
                this[i] = Math.Round(rand.NextDouble() * 20 - 15, 1);
            }
        }

        // Індексатор
        public double this[int i]
        {
            get
            {
                if (0 <= i && i < Length) return a[i];
                error = true;
                return 0;
            }
            set
            {
                if (0 <= i && i < Length) a[i] = value;
                else error = true;
            }
        }

        public (double, int) CalculateMetrics()
        {
            double sum = 0;
            for (int i = 0; i < Length; i++) sum += a[i];

            double avg = Math.Round(sum / Length, 2);
            int countAboveAvg = 0;

            for (int i = 0; i < Length; i++)
            {
                if (a[i] > avg) countAboveAvg++;
            }
            return (avg, countAboveAvg);
        }
    }
}
