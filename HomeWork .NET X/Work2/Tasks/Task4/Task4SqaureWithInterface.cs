namespace Training3.Training3.Task4
{
    using global::Training3.Training3.Task4.Interfaces;
    using System;

    public class Task4SqaureWithInterface:IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Sqaure");
        }
    }
}
