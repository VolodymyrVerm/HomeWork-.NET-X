using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    public class Task3Circle
    {
        const double PI = 3.14;

        public double GetSqaure(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }

        public double GetLength(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
