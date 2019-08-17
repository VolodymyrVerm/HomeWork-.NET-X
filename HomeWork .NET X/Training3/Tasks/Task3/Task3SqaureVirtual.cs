namespace Training3.Training3.Task3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;

    public class Task3SqaureVirtual:Task3FigureVirtual, IRunnable
    {
        public override void Draw()
        {
            Console.WriteLine("This is Sqaure");
        }

        public void Run()
        {
            Console.WriteLine("--Task3(virtual)--");
            Task3SqaureVirtual task = new Task3SqaureVirtual();
            task.Draw();
        }
    }
}
