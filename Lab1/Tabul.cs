using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x;
        }

        private double f2(double x)
        {
            return Math.Exp(-x) + Math.Pow(x, 0.25);
        }

        private double f3(double x)
        {
            return Math.Log(Math.Pow(x, 3) + Math.Pow(x, 2));
        }

        public void tab(double xn = -1.78, double xk = 11.99, double h = 0.5, double a = 0.8)
        {
            double x = xn;
            int i = 0;
            while (x <= xk)
            {
                double y;
                if (x <= 0)
                {
                    y = f1(x);
                }
                else if (x > 0 && x <= a)
                {
                    y = f2(x);
                }
                else
                {
                    y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}
