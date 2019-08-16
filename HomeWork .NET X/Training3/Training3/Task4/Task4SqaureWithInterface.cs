using System;
using System.Collections.Generic;
using System.Text;
using Training3.Training3.Task4.Interfaces;

namespace Training3.Training3.Task4
{
    public class Task4SqaureWithInterface:IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Sqaure");
        }
    }
}
