using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    public static class Task4Rectangle
    {
        public static double GetSqaure(double left_up_X, double left_up_Y, double right_down_X, double right_down_Y)
        {
            double a = right_down_X - left_up_X;
            double b = left_up_Y - right_down_Y;
            return a * b;
        }

        public static  double GetPerimetr(double left_up_X, double left_up_Y, double right_down_X, double right_down_Y)
        {
            double a = right_down_X - left_up_X;
            double b = left_up_Y - right_down_Y;
            return 2 * a + 2 * b;
        }
    }
}
