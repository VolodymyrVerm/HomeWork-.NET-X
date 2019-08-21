namespace Work2.Tasks.Task4
{
    using System;
    using Work2.Tasks.Task4.Interfaces;

    public class Task4SqaureWithInterface:IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Sqaure");
        }
    }
}
