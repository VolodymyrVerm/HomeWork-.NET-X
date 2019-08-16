using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    class Task5Complexnumber
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
            return (String.Format("{0} + {1}i", real, imaginary));
        }
        #endregion
    }
}
