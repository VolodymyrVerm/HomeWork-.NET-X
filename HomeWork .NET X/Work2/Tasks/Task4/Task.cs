namespace Work2.Tasks.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;
    using Work2.Tasks.Task4.Interfaces;

    public class Task:IRunnable
    {
        public void DrawAll(params IDrawable[] arr)
        {
            foreach (var t in arr)
            {
                if (t is IDrawable)
                {
                    (t as IDrawable).Draw();
                }
            }
        }

        public void Run()
        {
            Console.WriteLine("--Task4--");
            Task4RectangleWithInterface tsk1 = new Task4RectangleWithInterface();
            Task4SqaureWithInterface tsk2 = new Task4SqaureWithInterface();
            DrawAll(tsk1, tsk2);

        }
    }
}
