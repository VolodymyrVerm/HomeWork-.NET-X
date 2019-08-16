using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X.Training3
{
    public class TaskSqaureAbstract:Task1FigureAbstract
    {
        public TaskSqaureAbstract() { }

        public TaskSqaureAbstract(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Sqaure");
        }
    }
}
