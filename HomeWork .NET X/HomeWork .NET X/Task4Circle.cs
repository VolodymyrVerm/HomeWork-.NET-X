using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    public static class Task4Circle
    {
        const double PI = 3.14;

        public static double GetSqaure(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }

        public static double GetLength(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
