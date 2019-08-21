namespace Work2.Tasks.Task3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;

    public class Task3RectangleVirtual:Task3FigureVirtual,IRunnable
    {
        public override void Draw()
        {
            Console.WriteLine("This is Rectangle");
        }

        public void Run()
        {
            Task3RectangleVirtual task = new Task3RectangleVirtual();
            task.Draw();
        }
    }
}
