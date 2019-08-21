namespace Work2.Tasks
{
    using System;
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
