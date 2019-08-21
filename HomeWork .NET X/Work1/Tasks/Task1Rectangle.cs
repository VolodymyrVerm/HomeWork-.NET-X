namespace HomeWork_.NET_X
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;
    using HomeWork_.NET_X.Tasks;

    public class Task1Rectangle:IRunnable
    {
        Point left_top;

        Point right_down;

        public Task1Rectangle(double ltx, double lty, double rdx, double rdy)
        {
            if(ltx>rdx || lty<rdy)
            {
                throw new Exception("Values incorrect");
            }
            left_top = new Point(ltx, lty);
            right_down = new Point(rdx, rdy);
        }
        public Task1Rectangle() { }

        public double GetSqaure()
        {
            double width = right_down.X - left_top.X;
            double height = left_top.Y - right_down.Y;
            return width*height;
        }

        public double GetPerimetr()
        {
            double width = right_down.X - left_top.X;
            double height = left_top.Y - right_down.Y;
            return 2 * width + 2 * height;
        }

        public void Run()
        {
            Console.WriteLine("--Task1--");

            Console.WriteLine("Please input Left_X: ");
            double ltx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double lty = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double rdx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double rdy = Convert.ToDouble(Console.ReadLine());

            Task1Rectangle rect = new Task1Rectangle(ltx, lty,rdx,rdy);
            Console.WriteLine("Sqaure: {0}",rect.GetSqaure());
            Console.WriteLine("Perimetr: {0}", rect.GetPerimetr());
        }
    }
}
