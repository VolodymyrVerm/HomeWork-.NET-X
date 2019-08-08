using System;

namespace HomeWork_.NET_X
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Left_X: ");
            double L_X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input Left_Y: ");
            double L_Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input Right_X: ");
            double R_X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input Right_Y: ");
            double R_Y = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(L_X, L_Y, R_X, R_Y);

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", rect.GetSqaure(), rect.GetPerimetr());

            Console.WriteLine("Hello World!");
        }
    }
}
