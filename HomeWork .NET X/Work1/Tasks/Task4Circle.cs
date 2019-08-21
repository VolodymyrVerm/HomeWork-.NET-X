namespace Work1.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;
    public class Task4Circle:IRunnable
    {
        const double PI = 3.14;

        public static double GetSqaure(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Value incorrect");
            }
            return PI * Math.Pow(radius, 2);
        }

        public static double GetLength(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Value incorrect");
            }
            return 2 * PI * radius;
        }

        public void Run()
        {
            Console.WriteLine("--Task4(Circle)--");
            Console.WriteLine("Please, input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sqaure of circle is: {0}; Length of circle is: {1};", Task4Circle.GetSqaure(radius), Task4Circle.GetLength(radius));
        }
    }
}
