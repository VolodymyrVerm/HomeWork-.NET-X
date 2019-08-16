using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_.NET_X.Training3
{
    public abstract class Task1FigureAbstract
    {
        public readonly int X_position;
        public readonly int Y_position;

        public Task1FigureAbstract() { }

        public Task1FigureAbstract(int _x,int _y)
        {
            this.X_position = _x;
            this.Y_position = _y;
        }
        public abstract void Show();
    }
}
