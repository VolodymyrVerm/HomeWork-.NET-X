namespace HomeWork_.NET_X.Training3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Training.common.Interfaces;

    public class TaskSqaureAbstract:Task1FigureAbstract, IRunnable
    {
        public TaskSqaureAbstract() { }

        public TaskSqaureAbstract(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Sqaure");
        }

        public void Run()
        {
            Console.WriteLine("--Task(1-2)(abstract)--");
            TaskSqaureAbstract task = new TaskSqaureAbstract();
            task.Show();
        }
    }
}
