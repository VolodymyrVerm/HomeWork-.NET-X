using System;

namespace HomeWork_.NET_X
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            Console.WriteLine("Please input Left_X: ");
            double L_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double L_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double R_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double R_Y = Convert.ToDouble(Console.ReadLine());

            Task1Rectangle tsk1 = new Task1Rectangle(L_X, L_Y, R_X, R_Y);

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", tsk1.GetSqaure(), tsk1.GetPerimetr());
            #endregion

            #region Task2

            Task2Rectangle tsk2 = new Task2Rectangle();

            Console.WriteLine("Please input Left_X: ");
            tsk2.left_up_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            tsk2.left_up_Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            tsk2.right_down_X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            tsk2.right_down_Y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", tsk2.GetSqaure(), tsk2.GetPerimetr());
            #endregion

            #region Task3

            Task3Circle circle = new Task3Circle();

            Console.WriteLine("Please input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sqaure of circle is: {0}; Length of circle is: {1};", circle.GetSqaure(radius), circle.GetLength(radius));
            #endregion

            #region Task4

            Console.WriteLine("Please input radius: ");
            double radius4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sqaure of circle is: {0}; Length of circle is: {1};", Task4Circle.GetSqaure(radius4), Task4Circle.GetLength(radius4));

            Console.WriteLine("Please input Left_X: ");
            double L_X4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Left_Y: ");
            double L_Y4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_X: ");
            double R_X4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input Right_Y: ");
            double R_Y4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sqaure: {0}; Perimetr: {1};", Task4Rectangle.GetSqaure(L_X4,L_Y4,R_X4,R_Y4), Task4Rectangle.GetPerimetr(L_X4, L_Y4, R_X4, R_Y4));

            #endregion

            #region Task5
            Task5Complexnumber val1 = new Task5Complexnumber();
            Task5Complexnumber val2 = new Task5Complexnumber();

            Console.WriteLine("Please input FIRST number(real): ");
            val1.real = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input FIRST number(imaginary): ");
            val1.imaginary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input SECOND number(real): ");
            val2.real = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input SECOND number(imaginary): ");
            val2.imaginary = Convert.ToDouble(Console.ReadLine());
            

            Task5Complexnumber res1 = val1 * val2;
            Task5Complexnumber res2 = val1/val2;

            Console.WriteLine("First:  {0}", val1);
            Console.WriteLine("Second: {0}", val2);

            Console.WriteLine("Result (multiplication): {0}", res1);
            Console.WriteLine("Result (division): {0}", res2);
            #endregion
        }
    }
}
