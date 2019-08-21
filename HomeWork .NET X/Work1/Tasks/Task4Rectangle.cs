namespace Work1.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;
    public class Task4Rectangle:IRunnable
    {
        public static double GetSqaure(double left_up_X, double left_up_Y, double right_down_X, double right_down_Y)
        {
            if (left_up_X > right_down_X || left_up_Y < right_down_Y)
            {
                throw new Exception("Values incorrect");
            }
            double a = right_down_X - left_up_X;
            double b = left_up_Y - right_down_Y;
            return a * b;
        }

        public static  double GetPerimetr(double left_up_X, double left_up_Y, double right_down_X, double right_down_Y)
        {
            if (left_up_X > right_down_X || left_up_Y < right_down_Y)
            {
                throw new Exception("Values incorrect");
            }
            double a = right_down_X - left_up_X;
            double b = left_up_Y - right_down_Y;
            return 2 * a + 2 * b;
        }

        public void Run()
        {
            Console.WriteLine("--Task4(Rectangle)--");
            Console.WriteLine("Please input Left_X: ");
            double ltx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double lty = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double rdx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double rdy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", Task4Rectangle.GetSqaure(ltx, lty, rdx, rdy), Task4Rectangle.GetPerimetr(ltx, lty, rdx, rdy));
        }
    }
}
