using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X
{
    class ComplexNumber
    {
        public double real { get; set; }

        public double imaginary { get; set; }

        public ComplexNumber()
        {
           
        }

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            double real = first.real * second.real - first.imaginary * second.imaginary;
            double imaginary = first.real * second.imaginary + first.imaginary * second.real;

            return new ComplexNumber(real,imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber first, ComplexNumber second)
        {
            double real = (first.real * second.real + first.imaginary * second.imaginary)/(Math.Pow(second.real,2)+ Math.Pow(second.imaginary, 2));
            double imaginary = (first.imaginary * second.real-first.real * second.imaginary) / (Math.Pow(second.real, 2) + Math.Pow(second.imaginary, 2));

            return new ComplexNumber(real, imaginary);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
