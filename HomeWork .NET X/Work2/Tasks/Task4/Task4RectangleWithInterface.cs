
namespace Work2.Tasks.Task4
{
    using System;
    using Work2.Tasks.Task4.Interfaces;


    public class Task4RectangleWithInterface:IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
}
