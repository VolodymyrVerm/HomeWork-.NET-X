using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    class Rectangle
    {
        private double left_up_X;

        private double left_up_Y;

        private double right_down_X;

        private double right_down_Y;

        public Rectangle (double left_up_X, double left_up_Y, double right_down_X, double right_down_Y)
        {
            this.left_up_X = left_up_X;
            this.left_up_Y = left_up_Y;
            this.right_down_X = right_down_X;
            this.right_down_Y = right_down_Y;
        }

        public double GetSqaure()
        {
            double a = right_down_X - left_up_X;
            double b = left_up_Y - right_down_Y;
            return a * b;
        }

        public double GetPerimetr()
        {
            double a = right_down_X- left_up_X;
            double b = left_up_Y - right_down_Y;
            return 2 * a + 2 * b;
        }
    }
}
