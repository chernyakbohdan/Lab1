using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Array2D
    {
        public bool error = false;
        private int x_length;
        private int y_length;
        private int[,] a;

        public int X_length { get { return x_length; } set { x_length = value; } }
        public int Y_length { get { return y_length; } set { y_length = value; } }

        public Array2D()
        {
            X_length = 0;
            Y_length = 0;
            a = new int[X_length, Y_length];
            Generate();
        }
        public Array2D(int rows, int cols)
        {
            X_length = rows;
            Y_length = cols;
            a = new int[X_length, Y_length];
            Generate();
        }

        private void Generate()
        {
            Random rand = new Random();
            for (int i = 0; i < X_length; i++)
            {
                for (int j = 0; j < Y_length; j++)
                {
                    this[i, j] = rand.Next(-50, 50);
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < X_length && 0 <= j && j < Y_length) return a[i, j];
                error = true; return 0;
            }
            set
            {
                if (0 <= i && i < X_length && 0 <= j && j < Y_length) a[i, j] = value;
                else error = true;
            }
        }

        public int CountNegativeBelowMainDiagonal()
        {
            int count = 0;
            for (int i = 0; i < X_length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (this[i, j] < 0) count++;
                }
            }
            return count;
        }
    }
}
