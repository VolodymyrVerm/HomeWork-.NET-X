namespace HomeWork_.NET_X
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;
    public class Task3Circle: IRunnable
    {
        const double PI = 3.14;

        public double GetSqaure(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Value incorrect");
            }
            return PI * Math.Pow(radius, 2);
        }

        public double GetLength(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Value incorrect");
            }
            return 2 * PI * radius;
        }

        public void Run()
        {
            Console.WriteLine("--Task3--");
            Console.WriteLine("Please, input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Task3Circle circle = new Task3Circle();
            Console.WriteLine("Sqaure of circle is: {0}; Length of circle is: {1};", circle.GetSqaure(radius), circle.GetLength(radius));
        }
    }
}
