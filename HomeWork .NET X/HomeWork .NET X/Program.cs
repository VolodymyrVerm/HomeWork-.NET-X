using System;

namespace HomeWork_.NET_X
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            Console.WriteLine("Please input Left_X: ");
            double L_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double L_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double R_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double R_Y = Convert.ToDouble(Console.ReadLine());

            rect.left_up_X = L_X;

            rect.left_up_Y = L_Y;

            rect.right_down_X = R_X;

            rect.right_down_Y = R_Y;

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", rect.GetSqaure(), rect.GetPerimetr());
        }
    }
}
