namespace HomeWork_.NET_X
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;

    class Task5Complexnumber:IRunnable
    {
        #region Properties
        public double real { get; set; }

        public double imaginary { get; set; }
        #endregion

        #region Constructors
        public Task5Complexnumber()
        {         
        }

        public Task5Complexnumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region Override operators
        public static Task5Complexnumber operator *(Task5Complexnumber first, Task5Complexnumber second)
        {
            double real = first.real * second.real - first.imaginary * second.imaginary;
            double imaginary = first.real * second.imaginary + first.imaginary * second.real;

            return new Task5Complexnumber(real,imaginary);
        }

        public static Task5Complexnumber operator /(Task5Complexnumber first, Task5Complexnumber second)
        {
            double real = (first.real * second.real + first.imaginary * second.imaginary)/(Math.Pow(second.real,2)+ Math.Pow(second.imaginary, 2));
            double imaginary = (first.imaginary * second.real-first.real * second.imaginary) / (Math.Pow(second.real, 2) + Math.Pow(second.imaginary, 2));

            return new Task5Complexnumber(real, imaginary);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", this.real, this.imaginary));
        }
        #endregion

        public void Run()
        {
            Console.WriteLine("--Task5--");
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
            Task5Complexnumber res2 = val1 / val2;

            Console.WriteLine("First:  {0}", val1);
            Console.WriteLine("Second: {0}", val2);

            Console.WriteLine("Result (multiplication): {0}", res1);
            Console.WriteLine("Result (division): {0}", res2);
        }
    }
}
