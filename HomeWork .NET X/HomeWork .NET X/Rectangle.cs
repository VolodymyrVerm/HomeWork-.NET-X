using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    class Rectangle
    {
        public double left_up_X { get; set; }

        public double left_up_Y { get; set; }

        public double right_down_X { get; set; }

        public double right_down_Y { get; set; }


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
