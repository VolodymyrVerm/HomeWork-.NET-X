using System;

namespace HomeWork_.NET_X
{

    class Program
    {
        static void Main(string[] args)
        {
            #region

            Console.WriteLine("Please input Left_X: ");
            double L_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double L_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double R_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double R_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", Rectangle.GetSqaure(L_X, L_Y, R_X, R_Y), Rectangle.GetPerimetr(L_X, L_Y, R_X, R_Y));
            #endregion

            #region

            Console.WriteLine("Please input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sqaure of circle is: {0}; Length of circle is: {1};", Circle.GetSqaure(radius), Circle.GetLength(radius));
            #endregion
        }
    }
}
